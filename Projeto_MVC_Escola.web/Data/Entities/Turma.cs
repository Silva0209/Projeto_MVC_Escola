using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        [Display(Name = "Nome da Turma")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "O nome da turma não pode conter numeros ou caracteres especiais.")]
        [StringLength(10, ErrorMessage = "O nome da turma não pode ter  mais que 10 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o nome da turma")]
        public string nome_turma { get; set; }


        //[Required(ErrorMessage = "É necessário preencher o curso")]
        [Display(Name = "Nome do curso")]
        public int id_curso { get; set; }


        public Curso Curso { get; set; }
    }
}
