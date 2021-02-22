using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }


        [Required]
        [MinLength(6)]
        public string Password { get; set; }


        public bool RememberMe { get; set; }
    }
}
