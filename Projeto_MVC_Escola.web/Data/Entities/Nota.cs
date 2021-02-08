using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Nota
    {

        public int Id { get; set; }
        public int id_aluno { get; set; }
        public int id_disciplina { get; set; }
        public Decimal nota_final { get; set; }
        public string aprovado { get; set; }


        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
