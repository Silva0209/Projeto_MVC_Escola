using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class Turma
    {
        public int id_turma { get; set; }
        public string nome_turma { get; set; }
        public int id_curso { get; set; }

        public Curso Curso { get; set; }

    }
}
