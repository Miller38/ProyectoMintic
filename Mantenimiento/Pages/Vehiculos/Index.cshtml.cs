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
    public class IndexModel : PageModel
    {
        private readonly Mantenimiento.Persistencia.MantenimientoContext _context;

        public IndexModel(Mantenimiento.Persistencia.MantenimientoContext context)
        {
            _context = context;
        }

        public IList<Vehiculo> Vehiculo { get;set; }

        public async Task OnGetAsync()
        {
            Vehiculo = await _context.Vehiculo
                .Include(v => v.Cliente).ToListAsync();
        }
    }
}
