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
using Microsoft.AspNetCore.Authorization;


namespace Mantenimiento.Pages_Servicios
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public EditModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        [BindProperty]
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
                .ThenInclude(v => v.Cliente)
                .FirstOrDefaultAsync(m => m.ServicioID == id);

            if (Servicio == null)
            {
                return NotFound();
            }
            ViewData["ClienteID"] = new SelectList(_context.Cliente, "ID", "Apellidos");
            ViewData["TecnicoID"] = new SelectList(_context.Tecnico, "ID", "Apellidos");
            ViewData["VehiculoID"] = new SelectList(_context.Vehiculo, "VehiculoID", "Cilindraje");
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

            _context.Attach(Servicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicioExists(Servicio.ServicioID))
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

        private bool ServicioExists(int id)
        {
            return _context.Servicio.Any(e => e.ServicioID == id);
        }
    }
}
