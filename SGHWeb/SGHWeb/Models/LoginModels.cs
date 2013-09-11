using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGHWeb.Models
{
    public class LoginSGHModel
    {
        [Required(ErrorMessage = "Debe ingresar el Usuario")]
        [Display(Name="Usuario")]
        public string username { get; set; }

        [Required(ErrorMessage = "Debe ingresar la Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name="Contraseña")]
        public string password { get; set; }
    }
}