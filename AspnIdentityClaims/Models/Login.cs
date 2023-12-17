using System.ComponentModel.DataAnnotations;

namespace AspnIdentityClaims.Models
{
    public class Login
    {
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        [MaxLength(200)]
        public string ReturnUrl { get; set; }
    }
}
