using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mantenimiento.Dominio
{
    public class Servicio
    {
        
        public int ServicioID {get; set;}
        
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creacion")]
        public DateTime? FechaCreacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]            
        public string Descripcion {get; set;}
        
        // Un servicio tiene un cliente
        //public int ClienteID {get; set;}
        //public Cliente Cliente {get; set;}

        // Un servicio tiene un técnico
        public int TecnicoID {get; set;}
        public Tecnico Tecnico {get; set;}
        
        // Un servicio tiene un vehiculo
        [ForeignKey("VehiculoID")]
        public int VehiculoID {get; set;}
        public virtual Vehiculo Vehiculo {get; set;}
    }
}