using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Mantenimiento.Dominio
{
    public class Cliente : Persona
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public  string Email {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public  string Direccion {get; set;}

        // Un cliente tiene varios vehiculos
        public ICollection<Vehiculo> Vehiculos {get; set;}

        // Un cliente recibe varios servicios
        //public ICollection<Servicio> Servicios {get; set;}
    }
}