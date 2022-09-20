using System;
using System.Collections.Immutable;
using Mantenimiento.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Mantenimiento.Persistencia
{

    public class MantenimientoContext : DbContext
    {
        public MantenimientoContext(DbContextOptions<MantenimientoContext> options)
        :base(options)
        {
        }

        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Servicio> Servicio {get; set;}
        public DbSet<Tecnico> Tecnico {get; set;}
        public DbSet<Vehiculo> Vehiculo {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Vehiculo>()
            .HasMany(v => v.Servicios)
            .WithOne(s => s.Vehiculo)
            .OnDelete(DeleteBehavior.Cascade);
            

            builder.Entity<Servicio>()
            .HasOne(s => s.Vehiculo)
            .WithMany(v => v.Servicios)
            .HasForeignKey(s => s.VehiculoID)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}