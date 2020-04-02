using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ups.Api.ViewModels
{
    public class RegistroUsuarioViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage ="Informe um e-mail válido")]
        public string Email { get; set; }
        [Required]
        [StringLength(8,ErrorMessage ="A senha deve ter entre {1} e {2} caracteres", MinimumLength =6)]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="As senha informadas devem ser iguais")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginUsuarioViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "A senha deve ter entre {1} e {2} caracteres", MinimumLength = 6)]
        public string Password { get; set; }

    }
}
