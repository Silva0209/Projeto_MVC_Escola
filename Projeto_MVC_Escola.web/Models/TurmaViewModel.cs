using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto_MVC_Escola.web.Data.Entities;

namespace Projeto_MVC_Escola.web.Models
{
    public class TurmaViewModel : Turma
    {
        public IEnumerable<SelectListItem> cursos { get; set; }
    }
}
