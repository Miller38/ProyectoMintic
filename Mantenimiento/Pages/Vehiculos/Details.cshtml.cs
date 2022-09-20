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


namespace Mantenimiento.Pages_Vehiculos
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public DetailsModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public Vehiculo Vehiculo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehiculo = await _context.Vehiculo
                .Include(v => v.Servicios)
                .FirstOrDefaultAsync(m => m.VehiculoID == id);

            if (Vehiculo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
