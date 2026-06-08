using System;
using System.ComponentModel.DataAnnotations;

namespace Aluno.Models
{
    
    
}
    public class Aluno
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(20, ErrorMessage = "O RA deve ter no máximo 20 caracteres.")]
        
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório.")]
        [StringLength(100, ErrorMessage = "O curso deve ter no máximo 100 caracteres.")]
        
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        
        public DateTime DataNascimento { get; set; }
    }
}