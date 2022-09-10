using System;

namespace Mantenimiento.App.Dominio
{
    public class Tecnico : Persona
    {
        public int Id {get; set;}

        public int Codigo {get; set;}

        public string Cargo {get; set;}
    }
}