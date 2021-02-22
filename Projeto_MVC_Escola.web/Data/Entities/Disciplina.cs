using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Disciplina
    {
        public int Id { get; set; }


        [Display(Name = "Disciplina")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "O nome da disciplina não pode conter numeros ou caracteres especiais.")]
        [StringLength(30, ErrorMessage = "O nome da disciplina não pode ter  mais que 30 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o nome da disciplina")]
        public string nome_disciplina { get; set; }


        [Display(Name = "Área de Formação")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "A área de formação não pode conter numeros ou caracteres especiais.")]
        [StringLength(30, ErrorMessage = "A área de formação não pode ter  mais que 30 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher a área de formação")]
        public string area_formação { get; set; }


        [RegularExpression(@"([0 - 9] +)", ErrorMessage = "A carga hóraria da disciplina não pode conter numeros ou caracteres especiais.")]
        [Required(ErrorMessage = "É necessário preencher a carga hóraria da disciplina")]
        [Display(Name = "Carga Horária")]
        public DateTime carga_horaria_discplina { get; set; }


        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(8, ErrorMessage = "O cartão de cidadão deve ter 2 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher os créditos da disciplina")]
        [Display(Name = "Creditos da Disciplina")]
        public int  creditos_discplina { get; set; }



        [Display(Name = "Curso")]
        [Required(ErrorMessage = "É necessário preencher o curso")]
        public int id_curso { get; set; }



        [Display(Name = "Professor")]
        [Required(ErrorMessage = "É necessário preencher o professor")]
        public int id_professor { get; set; }
        
        
        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
    }
}
