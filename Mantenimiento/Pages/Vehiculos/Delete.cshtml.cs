using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;

namespace Mantenimiento.Pages_Vehiculos
{
    public class DeleteModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public DeleteModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vehiculo Vehiculo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehiculo = await _context.Vehiculo
                .Include(v => v.Cliente)
                .FirstOrDefaultAsync(m => m.VehiculoID == id);

            if (Vehiculo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehiculo = await _context.Vehiculo.FindAsync(id);

            if (Vehiculo != null)
            {
                _context.Vehiculo.Remove(Vehiculo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
