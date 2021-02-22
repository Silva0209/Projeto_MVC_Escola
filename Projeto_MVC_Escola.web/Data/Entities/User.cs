﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }


        [Display(Name ="Full Name")]
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

    }
}