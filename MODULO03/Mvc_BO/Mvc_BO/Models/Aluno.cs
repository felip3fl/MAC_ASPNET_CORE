using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BO.Models
{
    public class Aluno
    {
        //[BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="O nome deve ter no minuto 5 caracteres")]
        [Display(Name ="Informe o nome do cliente")]
        public string Nome { get; set; }

        [Display(Name = "Informe o sexo do cliente")]
        [Required(ErrorMessage = "O sexo deve ser informado")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O email deve ser informado")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O data de nascimento deve ser informado")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Nascimento { get; set; }

    }
}
