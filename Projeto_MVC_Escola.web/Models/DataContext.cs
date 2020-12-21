using Microsoft.EntityFrameworkCore;
using Projeto_MVC_Escola.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DataContext(DbContextOptions<DataContext>options) : base(options)
            {
            
            }
     
}
}
