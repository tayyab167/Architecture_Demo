using PrimeHrmsApi.Domain.Entities;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PrimeHrmsApi.Domain.Auth
{
    public class AuthenticationResponse
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public tblSetting Permissions { get; set; }
        public bool IsVerified { get; set; }
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}
