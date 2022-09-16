using Microsoft.EntityFrameworkCore;
using Mantenimiento.App.Dominio;
using System;

namespace Mantenimiento.App.Persistencia
{
    public class AppContext : DbContext
    {
        private const string connectionString = "Server=DESKTOP-BKG5BK7;Database=ContactosApp;trusted_Connection=True;MultipleActiveResultSets=true";


        public DbSet<Auto> Autos {get; set;}

        public DbSet<Camioneta> Camionetas {get; set;}

        public DbSet<Cliente> Clientes {get; set;}

        public DbSet<Persona> Personas {get; set;}

        public DbSet<Servicio> Servicios {get; set;}

        public DbSet<Tecnico> Tecnicos {get; set;}

        public DbSet<Vehiculo> Vehiculos {get; set;}
        
        public DbSet<HistorialDeRevision> HistorialDeRevision {get; set;}

        public AppContext(){}

        public AppContext(DbContextOptions<AppContext> options)
        :base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }


    }
}