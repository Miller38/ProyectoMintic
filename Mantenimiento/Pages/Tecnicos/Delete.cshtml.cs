using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;

namespace Mantenimiento.Pages_Tecnicos
{
    public class DeleteModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public DeleteModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tecnico Tecnico { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tecnico = await _context.Tecnico.FirstOrDefaultAsync(m => m.ID == id);

            if (Tecnico == null)
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

            Tecnico = await _context.Tecnico.FindAsync(id);

            if (Tecnico != null)
            {
                _context.Tecnico.Remove(Tecnico);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
