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


namespace Mantenimiento.Pages_Servicios
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
        ViewData["TecnicoID"] = new SelectList(_context.Tecnico, "ID", "NombreCompleto");
        ViewData["VehiculoID"] = new SelectList(_context.Vehiculo, "VehiculoID", "Placa");
            return Page();
        }

        [BindProperty]
        public Servicio Servicio { get; set; }

        [BindProperty]
        public Cliente Cliente {get; set;}

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Servicio.Add(Servicio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
