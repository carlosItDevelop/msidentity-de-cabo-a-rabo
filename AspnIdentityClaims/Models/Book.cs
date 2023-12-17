using System;
using System.ComponentModel.DataAnnotations;

namespace AspnIdentityClaims.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do livro")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Informe o(s) autor(es) do livro")]
        [MaxLength(250)]
        public string Author { get; set; }

        public DateTime Published { get; set; }
    }
}
