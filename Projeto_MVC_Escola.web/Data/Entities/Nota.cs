using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Nota
    {

        public int Id { get; set; }



        [Display(Name = "Nome do Aluno")]
        [Required(ErrorMessage = "É necessário preencher o nome do aluno")]
        public int id_aluno { get; set; }



        [Display(Name = "Nome do Disciplina")]
        [Required(ErrorMessage = "É necessário preencher a disciplina")]
        public int id_disciplina { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza uma nota valida")]
        [Required(ErrorMessage = "É necessário preencher a nota final")]
        [Display(Name = "Nota Final")]
        public Decimal nota_final { get; set; }


        [Display(Name = "Aprovação")]
        public string aprovado { get; set; }


        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
