using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;
using Microsoft.AspNetCore.Authorization;


namespace Mantenimiento.Pages_Servicios
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public DetailsModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public Servicio Servicio { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Servicio = await _context.Servicio
                .Include(s => s.Tecnico)
                .Include(s => s.Vehiculo)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ServicioID == id);

            if (Servicio == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
