using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Comandos.BorrarPaciente;

public class ComandoBorrarPaciente : IRequest
{
    public required Guid Id { get; set; }
}
