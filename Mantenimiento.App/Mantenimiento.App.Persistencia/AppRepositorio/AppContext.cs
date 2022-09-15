using Microsoft.EntityFrameworkCore;
using Mantenimiento.App.Dominio;
using System;

namespace Mantenimiento.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Auto> Autos {get; set;}

        public DbSet<Camioneta> Camionetas {get; set;}

        public DbSet<Cliente> Clientes {get; set;}

        public DbSet<Persona> Personas {get; set;}

        public DbSet<Servicio> Servicios {get; set;}

        public DbSet<Tecnico> Tecnicos {get; set;}

        public DbSet<Vehiculo> Vehiculos {get; set;}
        
        public DbSet<HistorialDeRevision> HistorialDeRevision {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 

        {
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MantenimientoApp.Data");
            }
        }
    }
}