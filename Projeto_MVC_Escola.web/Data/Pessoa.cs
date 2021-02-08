using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string genero { get; set; }
        public string cc { get; set; }
        public string nif { get; set; }
        public string contacto { get; set; }


        public int morada { get; set; }
        public int localidade { get; set; }
        public int cp_1 { get; set; }
        public int cp_2 { get; set; }

        public string ImageUrl { get; set; }
        public string email { get; set; }
    }
}
