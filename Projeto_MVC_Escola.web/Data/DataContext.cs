using Microsoft.EntityFrameworkCore;
using Projeto_MVC_Escola.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_MVC_Escola.web.Models;

namespace Projeto_MVC_Escola.web.Models
{
    public class DataContext : DbContext
    {
        //Isto e o que vai pegar nas tuas classes e vai transformar em tabelas na Base  de Dados
        //DBContext da tabela Aluno
        public DbSet<Aluno> Alunos { get; set; }
        //DBContext da tabela Turma
        public DbSet<Turma> Turmas { get; set; }
        //DBContext da tabela Disciplinas
        public DbSet<Disciplina> Disciplinas { get; set; }
        //DBContext da tabela Cursos
        public DbSet<Curso> Cursos { get; set; }
        //DBContext da tabela Professores
        public DbSet<Professor> Professores { get; set; }
        //DBContext da tabela Notas
        public DbSet<Nota> Notas { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
