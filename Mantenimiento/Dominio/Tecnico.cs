using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.Dominio
{

    public enum Cargo {
        A, B, C
    }

    public class Tecnico : Persona
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Codigo {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Cargo? Cargo {get; set;}

        // Un técnico hace varios servicios
        public ICollection<Servicio> Servicios {get; set;}
    }
}