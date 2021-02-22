using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Curso")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "O nome do curso não pode conter numeros ou caracteres especiais.")]
        [StringLength(30, ErrorMessage = "O nome não pode ter  mais que 30 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o nome do curso")]
        public string nome_curso { get; set; }


        [Display(Name = "Carga Horária")]
        [RegularExpression(@"([0 - 9] +)", ErrorMessage = "A carga hóraria do curso não pode conter numeros ou caracteres especiais.")]
        [Required(ErrorMessage = "É necessário preencher a carga hóraria do curso")]
        public int carga_horaria_curso { get; set; }



        [Display(Name = "Data Inicial")]
        [Required(ErrorMessage = "É necessário preencher a data inicial do curso")]
        public DateTime data_inicio { get; set; }


        [Display(Name = "Data Final")]
        [Required(ErrorMessage = "É necessário preencher a data final do curso")]
        public DateTime data_fim { get; set; }
        
    }
}
