using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using PrimeHrmsApi.Domain;
using PrimeHrmsApi.Domain.Auth;
using PrimeHrmsApi.Domain.Common;
using PrimeHrmsApi.Domain.Enum;
using PrimeHrmsApi.Domain.Settings;
using PrimeHrmsApi.Service.Contract;
using PrimeHrmsApi.Service.Exceptions;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PrimeHrmsApi.Domain.Entities;

namespace PrimeHrmsApi.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IEmailService _emailService;
        private readonly ISqlDataAccess _db;

        private readonly JWTSettings _jwtSettings;
        private readonly IDateTimeService _dateTimeService;
        private readonly IFeatureManager _featureManager;
        private readonly IApplicationContext _context;
        public AccountService(IApplicationContext context, ISqlDataAccess db,
            IOptions<JWTSettings> jwtSettings,
            IDateTimeService dateTimeService,
            IEmailService emailService,
            IFeatureManager featureManager)
        {
            _jwtSettings = jwtSettings.Value;
            _dateTimeService = dateTimeService;
            _emailService = emailService;
            _featureManager = featureManager;
            _context = context;
            _db = db;
        }

        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress)
        {
            var user = await _context.tblEmployeeMgmt.Where(x => x.varEmail == request.Email && x.varPassword == EncriptionDecriptionHelper.Encrypt(request.Password)).Select(x=> new { x.varFirstName ,x.intSeqId,x.intCompanyId,x.isActive,x.varEmail}).AsNoTracking().FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ApiException($"Email or Password Incorrect for  {request.Email}.");
            }
            if (user.isActive==false)
            {
                throw new ApiException($"Account Not Confirmed for '{request.Email}'.");
            }
         
            JwtSecurityToken jwtSecurityToken = await GenerateJWToken(user);
            AuthenticationResponse response = new AuthenticationResponse();
            response.Id = user.intSeqId;
            response.CompanyId = user.intCompanyId;
            response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.Email = request.Email;
            response.UserName = user.varFirstName;
            //var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            //response.Permissions = await _context.tblSetting.Where(x => x.intCompanyId== user.intCompanyId).AsNoTracking().FirstOrDefaultAsync(); 
            response.Permissions = await _db.LoadDataByQuery<tblSetting>("select * from tblsetting where intcompanyid=77"); 
            response.IsVerified = true;
            var refreshToken = GenerateRefreshToken(ipAddress);
            response.RefreshToken = refreshToken.Token;
            return new Response<AuthenticationResponse>(response, $"Authenticated {user.varFirstName}");
        }

        public async Task<Response<string>> RegisterAsync(RegisterRequest request, string origin)
        {
        //    //var userWithSameUserName = await _userManager.FindByNameAsync(request.UserName);
        //    if (userWithSameUserName != null)
        //    {
        //        throw new ApiException($"Username '{request.UserName}' is already taken.");
        //    }
        //    var user = new ApplicationUser
        //    {
        //        Email = request.Email,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        UserName = request.UserName
        //    };
        //    var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);
        //    if (userWithSameEmail == null)
        //    {
        //        var result = await _userManager.CreateAsync(user, request.Password);
        //        if (result.Succeeded)
        //        {
        //            await _userManager.AddToRoleAsync(user, Roles.Basic.ToString());
        //            var verificationUri = await SendVerificationEmail(user, origin);

        //            if (await _featureManager.IsEnabledAsync(nameof(FeatureManagement.EnableEmailService)))
        //            {
        //                await _emailService.SendEmailAsync(new MailRequest() { From = "amit.naik8103@gmail.com", ToEmail = user.Email, Body = $"Please confirm your account by visiting this URL {verificationUri}", Subject = "Confirm Registration" });
        //            }
        //            return new Response<string>(user.Id, message: $"User Registered. Please confirm your account by visiting this URL {verificationUri}");
        //        }
        //        else
        //        {
        //            throw new ApiException($"{result.Errors.ToList()[0].Description}");
        //        }
        //    }
        //    else
        //    {
        //        throw new ApiException($"Email {request.Email } is already registered.");
        //    }
               throw new ApiException("");

    }

    private async Task<JwtSecurityToken> GenerateJWToken(dynamic user)
        {
            //var userClaims = await _userManager.GetClaimsAsync(user);
            //var roles = await _userManager.GetRolesAsync(user);

            //var roleClaims = new List<Claim>();

            //for (int i = 0; i < roles.Count; i++)
            //{
            //    roleClaims.Add(new Claim("roles", roles[i]));
            //}

            string ipAddress = IpHelper.GetIpAddress();

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.varEmail),
                new Claim("UserId", user.intSeqId.ToString()),
                new Claim("ip", ipAddress),
                new Claim("CompanyId",user.intCompanyId.ToString() ),
            };
            //.Union(userClaims)ss
            //.Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private async Task<string> SendVerificationEmail(ApplicationUser user, string origin)
        {
            //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //var route = "api/account/confirm-email/";
            //var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            //var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id);
            //verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
            ////Email Service Call Here
            //return verificationUri;
            throw new ApiException($"Error occured while reseting the password.");

        }

        public async Task<Response<string>> ConfirmEmailAsync(string userId, string code)
        {
            //var user = await _userManager.FindByIdAsync(userId);
            //code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            //var result = await _userManager.ConfirmEmailAsync(user, code);
            //if (result.Succeeded)
            //{
            //    return new Response<string>(user.Id, message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
            //}
            //else
            //{
            //    throw new ApiException($"An error occured while confirming {user.Email}.");
            //}
            throw new ApiException($"Error occured while reseting the password.");

        }

        private RefreshToken GenerateRefreshToken(string ipAddress)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow,
                CreatedByIp = ipAddress
            };
        }

        public async Task ForgotPassword(ForgotPasswordRequest model, string origin)
        {
            //var account = await _userManager.FindByEmailAsync(model.Email);

            //// always return ok response to prevent email enumeration
            //if (account == null) return;

            //var code = await _userManager.GeneratePasswordResetTokenAsync(account);
            //var route = "api/account/reset-password/";
            //var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            //var emailRequest = new MailRequest()
            //{
            //    Body = $"You reset token is - {code}",
            //    ToEmail = model.Email,
            //    Subject = "Reset Password",
            //};
            //await _emailService.SendEmailAsync(emailRequest);
            throw new ApiException($"Error occured while reseting the password.");

        }

        public async Task<Response<string>> ResetPassword(ResetPasswordRequest model)
        {
            //var account = await _userManager.FindByEmailAsync(model.Email);
            //if (account == null) throw new ApiException($"No Accounts Registered with {model.Email}.");
            //var result = await _userManager.ResetPasswordAsync(account, model.Token, model.Password);
            //if (result.Succeeded)
            //{
            //    return new Response<string>(model.Email, message: $"Password Resetted.");
            //}
            //else
            //{
            //    throw new ApiException($"Error occured while reseting the password.");
            //}
            throw new ApiException($"Error occured while reseting the password.");

        }
    }

}
