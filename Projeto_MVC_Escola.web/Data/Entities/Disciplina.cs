using Projeto_MVC_Escola.web.Models;
using System;using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string nome_disciplina { get; set; }
        public string area_formação { get; set; }
        public DateTime carga_horaria_discplina { get; set; }
        public DateTime creditos_discplina { get; set; }

        public int id_curso { get; set; }
        public int id_professor { get; set; }
        
        
        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
    }
}
