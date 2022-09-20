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


namespace Mantenimiento.Pages_Tecnicos
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public DetailsModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

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
    }
}
