using DientesLimpios.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DientesLimpios.Persistencia.Configuraciones;

public class PacienteConfig : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.Property(prop => prop.Nombre)
        .HasMaxLength(250)
        .IsRequired();

        builder.ComplexProperty(prop => prop.Email, accion =>
        {
            accion.Property(e => e.Valor).HasColumnName("Email").HasMaxLength(254);
        });

    }
}