using System;
using System.ComponentModel.DataAnnotations;


namespace Mantenimiento.App.Dominio
{

    public class Vehiculo
    {
        
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Propietario {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo de combustible")]
        public string TipoDeCombustible {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Placa  {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cilindraje  {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public string Color {get; set;}

    
    }
}