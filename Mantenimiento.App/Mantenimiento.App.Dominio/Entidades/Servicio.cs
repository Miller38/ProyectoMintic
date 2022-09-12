using System;
using System.ComponentModel.DataAnnotations;


namespace Mantenimiento.App.Dominio
{
    public class Servicio
    {
        public int Id {get; set;}

        
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creacion")]
        public DateTime? FechaCreacion { get; set; }

        
        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Descripcion {get; set;}
        
    }
}