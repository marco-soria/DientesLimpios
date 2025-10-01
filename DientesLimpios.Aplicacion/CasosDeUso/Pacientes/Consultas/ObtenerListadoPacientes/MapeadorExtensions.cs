using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Consultas.ObtenerListadoPacientes;

public static class MapeadorExtensions
{
    public static PacienteListadoDTO ADto(this Paciente paciente)
    {
        var dto = new PacienteListadoDTO
        {
            Id = paciente.Id,
            Nombre = paciente.Nombre,
            Email = paciente.Email.Valor
        };
        return dto;
    }
}