using ExpressiveAnnotations.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC_Escola.web.Data
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "O nome não pode conter numeros ou caracteres especiais.")]
        [StringLength(100, ErrorMessage = "O nome não pode ter  mais que 100 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o nome")]

        public string nome { get; set; }

        [Display(Name = "Genero")]
        public string genero { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(8, ErrorMessage = "O cartão de cidadão deve ter 8 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o cartão de cidadão")]
        [Display(Name = "Cartão de Cidadão")]
        public string cc { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(9, ErrorMessage = "O numero de identificação  deve so pode ter 9 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o NIF")]
        [Display(Name = "NIF")]
        public string nif { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(9, ErrorMessage = "O contacto deve ter 9 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher o contacto")]
        [Display(Name = "Contacto")]
        public string contacto { get; set; }

        [Display(Name = "Morada")]
        [StringLength(100, ErrorMessage = "A morada não pode ter  mais que 100 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher a morada")]
        public string morada { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "A localidade não pode conter numeros ou caracteres especiais.")]
        [StringLength(100, ErrorMessage = "A localidade ter  mais que 100 caracteres.")]
        [Required(ErrorMessage = "É necessário preencher a localidade")]
        [Display(Name = "Localidade")]
        public string localidade { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(4, ErrorMessage = "O codigo Postal 1  só pode ter 4 digitos.")]
        [Display(Name = "Codigo Postal 1")]
        [Required(ErrorMessage = "É necessário preencher o codigo postal 1")]
        public string cp_1 { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor introduza um numero valido")]
        [StringLength(3, ErrorMessage = "O codigo Postal 2  só pode ter 3 digitos.")]
        [Display(Name = "Codigo Postal 2")]
        [Required(ErrorMessage = "É necessário preencher o codigo postal 2")]

        public string cp_2 { get; set; }

        public string ImageUrl { get; set; }

        [StringLength(50, ErrorMessage = "O email só pode ter 3 digitos.")]
        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "É necessário preencher o email")]
        public string email { get; set; }
    }
}
