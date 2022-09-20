using System;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.Dominio 
{
    public class Persona
    {
        public int ID {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Nombre {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Apellidos {get; set;}
        
        [Required(ErrorMessage = "Este campo es obligatorio")]    
        public string Telefono  {get; set;}

        public string NombreCompleto
        {
            get {
                return Nombre + " " + Apellidos;
            }
        }
    }
}