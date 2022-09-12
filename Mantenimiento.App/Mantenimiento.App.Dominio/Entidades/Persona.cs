using System;
using System.ComponentModel.DataAnnotations;


namespace Mantenimiento.App.Dominio
{
    public class Persona
    {        
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Nombre {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Apellidos {get; set;}
        
        [Required(ErrorMessage = "Este campo es obligatorio")]    
        public string Telefono  {get; set;}
    }
}
