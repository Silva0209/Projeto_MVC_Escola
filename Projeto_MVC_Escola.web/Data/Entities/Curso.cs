
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string nome_curso { get; set; }
        public DateTime carga_horaria_curso { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        
    }
}
