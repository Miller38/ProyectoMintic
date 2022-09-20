using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mantenimiento.Dominio;
using Mantenimiento.Persistencia;
using Microsoft.AspNetCore.Authorization;


namespace Mantenimiento.Pages_Vehiculos
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public CreateModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClienteID"] = new SelectList(_context.Cliente, "ID", "NombreCompleto");
            return Page();
        }

        [BindProperty]
        public Vehiculo Vehiculo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vehiculo.Add(Vehiculo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
