﻿using DientesLimpios.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DientesLimpios.Persistencia;

public class DientesLimpiosDbContext : DbContext
{
    public DientesLimpiosDbContext(DbContextOptions<DientesLimpiosDbContext> options) : base(options)
    {
    }

    protected DientesLimpiosDbContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DientesLimpiosDbContext).Assembly);
    }

    public DbSet<Consultorio> Consultorios { get; set; }
}