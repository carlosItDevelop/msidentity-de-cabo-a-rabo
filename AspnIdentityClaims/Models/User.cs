using System.ComponentModel.DataAnnotations;

namespace AspnIdentityClaims.Models
{
    public class User
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", 
            ErrorMessage = "E-mail inválido")]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Password { get; set; }
    }
}
