using System.Collections;
using System.Collections.Generic;
using Mantenimiento.App.Dominio;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Mantenimiento.App.Persistencia
{
    public interface IRepository
    {       

        Persona Add(Persona persona);

        Persona Update(Persona persona);

        void Delete(int Idpersona);

        Persona Get(int Idpersona);

        IEnumerable<Persona> GetAll();
    }
}
