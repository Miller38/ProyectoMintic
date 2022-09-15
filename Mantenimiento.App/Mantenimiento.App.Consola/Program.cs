using System;
using Mantenimiento.App.Dominio;
using Mantenimiento.App.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Mantenimiento.App.Consola
{
    class Program
    {
        private static IRepository _repo = new Repository(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            AddPersona(); 
            //BuscarPersona();
        }

        private static void AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Nancy",
                Apellidos = "Valencia",
                Telefono = "676767"
            };
            _repo.Add(persona);        
        }
        private static void BuscarPersona(int idPersona)
    {
        var persona = _repo.Get(idPersona);  
        Console.WriteLine(persona.Nombre+""+persona.Apellidos);     
    }

    }

    
}
