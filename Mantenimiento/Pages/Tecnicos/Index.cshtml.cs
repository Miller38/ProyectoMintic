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
    public class IndexModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public IndexModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public IList<Tecnico> Tecnico { get;set; }

        public async Task OnGetAsync()
        {
            Tecnico = await _context.Tecnico.ToListAsync();
        }
    }
}
