using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mantenimiento.App.Dominio;
using Mantenimiento.App.Persistencia;

namespace Mantenimiento.App.Frontend.Pages
{   
    public class ListModel : PageModel
    {   
        private readonly IRepository _repo;

        public IEnumerable<Persona> Personas {get; set;}

        public ListModel(IRepository repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
            Console.WriteLine("hola");
            Personas = _repo.GetAll();
        }
    }
}
