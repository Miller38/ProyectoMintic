using System;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.App.Dominio
{
    public class Auto 
    {        
        public  int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]    
        public  string Tipo {get; set;}
        
    }
}