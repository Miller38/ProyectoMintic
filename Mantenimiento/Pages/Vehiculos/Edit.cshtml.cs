using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;

namespace Mantenimiento.Pages_Vehiculos
{
    public class EditModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public EditModel(Mantenimiento.Persistencia.MantenimientoContext context)
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
                .Include(v => v.Cliente).FirstOrDefaultAsync(m => m.VehiculoID == id);

            if (Vehiculo == null)
            {
                return NotFound();
            }
           ViewData["ClienteID"] = new SelectList(_context.Cliente, "ID", "NombreCompleto");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(Vehiculo.VehiculoID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculo.Any(e => e.VehiculoID == id);
        }
    }
}
