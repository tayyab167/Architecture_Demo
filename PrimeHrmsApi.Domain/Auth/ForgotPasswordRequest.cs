using System.ComponentModel.DataAnnotations;

namespace PrimeHrmsApi.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
