using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App_Prestamos.Models;

public partial class AppPrestamosContext : DbContext
{
    public AppPrestamosContext()
    {
    }

    public AppPrestamosContext(DbContextOptions<AppPrestamosContext> options)
        : base(options)
    {
    }

  

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.IdPrestamo).HasName("PK__Prestamo__A4876C13734CFC2C");

            entity.ToTable("Prestamo");

            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Deuda)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("deuda");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaFinal).HasColumnName("fechaFinal");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Plazo).HasColumnName("plazo");
            entity.Property(e => e.Prestamo1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prestamo");
            entity.Property(e => e.Ruc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ruc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
