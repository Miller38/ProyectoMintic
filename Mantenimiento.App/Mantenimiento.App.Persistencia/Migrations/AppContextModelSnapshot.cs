﻿// <auto-generated />
using Mantenimiento.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mantenimiento.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mantenimiento.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fecha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Servicios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Servicio");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cilindraje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Propietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeCombustible")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Vehiculo");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("Mantenimiento.App.Dominio.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Tecnico", b =>
                {
                    b.HasBaseType("Mantenimiento.App.Dominio.Persona");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.HistorialDeRevision", b =>
                {
                    b.HasBaseType("Mantenimiento.App.Dominio.Servicio");

                    b.HasDiscriminator().HasValue("HistorialDeRevision");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Auto", b =>
                {
                    b.HasBaseType("Mantenimiento.App.Dominio.Vehiculo");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Auto");
                });

            modelBuilder.Entity("Mantenimiento.App.Dominio.Camioneta", b =>
                {
                    b.HasBaseType("Mantenimiento.App.Dominio.Vehiculo");

                    b.Property<int>("CapacidadDeCarga")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Camioneta");
                });
#pragma warning restore 612, 618
        }
    }
}
