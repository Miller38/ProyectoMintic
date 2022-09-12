using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mantenimiento.App.Dominio;

namespace Mantenimiento.App.Persistencia.AppRepositorio
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;            
        } 

        public RepositorioPersona(){}

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaEncontrada.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idpersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(
                p => p.Id == idpersona
            );

            if(personaEncontrada == null)
            return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.Id == idPersona
            );
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(
                p => p.Id == persona.Id 
            );
            if(personaEncontrada!= null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Telefono = persona.Telefono;
            
                _appContext.SaveChanges();

            }
        
            return personaEncontrada;
        }
        

    }
}