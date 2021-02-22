using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto_MVC_Escola.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Models
{
    public class NotaViewModel : Nota
    {
        public IEnumerable<SelectListItem> alunos { get; set; }
        public IEnumerable<SelectListItem> disciplinas { get; set; }
    }
}
