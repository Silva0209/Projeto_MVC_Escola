using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto_MVC_Escola.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class DisciplinaViewModel : Disciplina
    {
        public IEnumerable<SelectListItem> cursos { get; set; }
        public IEnumerable<SelectListItem> professores { get; set; }

    }
}
