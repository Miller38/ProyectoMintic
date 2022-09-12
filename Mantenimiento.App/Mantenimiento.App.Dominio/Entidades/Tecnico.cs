using System;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.App.Dominio
{
    public class Tecnico 
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Codigo {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cargo {get; set;}
    }
}