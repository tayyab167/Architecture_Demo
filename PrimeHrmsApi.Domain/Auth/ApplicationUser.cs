using System.Collections.Generic;

namespace PrimeHrmsApi.Domain.Auth
{
    public class ApplicationUser 
    {public string Id { get; set; }    
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }    
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}