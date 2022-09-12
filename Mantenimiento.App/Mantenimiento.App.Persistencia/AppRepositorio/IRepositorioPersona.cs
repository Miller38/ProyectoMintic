using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mantenimiento.App.Dominio;

namespace Mantenimiento.App.Persistencia.AppRepositorio
{
    public interface IRepositorioPersona
    {
        
        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        void DeletePersona(int Idpersona);

        Persona GetPersona(int Idpersona);

        IEnumerable<Persona> GetAllPersonas();

    }
}