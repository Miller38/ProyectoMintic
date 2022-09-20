using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;

namespace Mantenimiento.Pages_Servicios
{
    public class IndexModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public IndexModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public IList<Servicio> Servicio { get;set; }

        public async Task OnGetAsync()
        {
            Servicio = await _context.Servicio
                .Include(s => s.Tecnico)
                .Include(s => s.Vehiculo).ToListAsync();
        }
    }
}
