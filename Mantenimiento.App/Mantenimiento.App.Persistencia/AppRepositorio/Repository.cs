using System;
using System.Collections.Generic;
using System.Linq;
using Mantenimiento.App.Dominio;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Mantenimiento.App.Persistencia
{
    public class Repository: IRepository
    {
        private readonly AppContext _appContext;

        public Repository(AppContext appContext)
        {
            _appContext = appContext;            
        } 

        public Repository(){}

        Persona IRepository.Add(Persona persona)
        {
            var new_persona = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }

        void IRepository.Delete(int IdPersona)
        {
            var personaExiste = _appContext.Personas.FirstOrDefault(
                p => p.Id == IdPersona
            );

            if(personaExiste == null)
            return;
            _appContext.Remove(IdPersona);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepository.GetAll()
        {
            Console.WriteLine("hola");
            return _appContext.Personas;
        }

        Persona IRepository.Get(int IdPersona)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.Id == IdPersona
            );
        }

        Persona IRepository.Update(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(
                p => p.Id == persona.Id
            );
            if (personaEncontrada!= null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Telefono = persona.Telefono;
            }
        _appContext.SaveChanges();
        return personaEncontrada;
        }
        
    }
}


