using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Aluno : Pessoa
    {
        [Display(Name = "Turma")]
        public Turma Turma { get; set; }

        [Display(Name = "Turma")]
        [Required(ErrorMessage = "É necessário preencher a turma")]
        public int id_turma { get; set; }
    }
}
