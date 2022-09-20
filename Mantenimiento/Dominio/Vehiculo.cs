using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mantenimiento.Dominio
{

    public enum Tipo {
        Automovil, Camioneta, Bus, Motocicleta
    }

    public enum Combustible {
        Gas, Gasolina, Diesel, Electrico
    }

    public class Vehiculo
    {
         public int VehiculoID {get; set;}

        [DisplayFormat(NullDisplayText = "Tipo de automovil")]
        public Tipo? Tipo {get; set;}

        [DisplayFormat(NullDisplayText = "Tipo de combustible")]
        public Combustible? Combustible {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Placa  {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cilindraje  {get; set;}

        [Required(ErrorMessage = "Este campo es obligatorio")]        
        public string Color {get; set;}

        // Un vehículo tiene un Cliente
        public int ClienteID {get; set;}
        public Cliente Cliente {get; set;}

        // Un vehículo recibe varios servicios
        public virtual ICollection<Servicio> Servicios {get; set;}
    }
}