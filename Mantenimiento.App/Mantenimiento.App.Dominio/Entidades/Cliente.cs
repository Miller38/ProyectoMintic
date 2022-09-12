using System;
using System.ComponentModel.DataAnnotations;


namespace Mantenimiento.App.Dominio
{
    public class Cliente 
    {        
        public  int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public  string Email {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public  string Direccion {get; set;}

    
    }
}
