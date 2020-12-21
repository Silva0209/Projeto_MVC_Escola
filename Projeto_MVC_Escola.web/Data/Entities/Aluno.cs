using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string nome_aluno { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public string email_aluno { get; set; }
        public string morada_aluno { get; set; }
        public int cp_1_aluno { get; set; }
        public int cp_2_aluno { get; set; }
        public int id_turma { get; set; }
    }
}
