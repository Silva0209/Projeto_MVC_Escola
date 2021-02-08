using Projeto_MVC_Escola.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data.Entities
{
    public class Aluno : Pessoa
    {
        public Turma Turma { get; set; }
        public int id_turma { get; set; }
    }
}
