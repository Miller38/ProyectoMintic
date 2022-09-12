using System;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.App.Dominio
{
    public class Camioneta 
    {        
        public  int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public  int CapacidadDeCarga {get; set;}
        
    
    }
}