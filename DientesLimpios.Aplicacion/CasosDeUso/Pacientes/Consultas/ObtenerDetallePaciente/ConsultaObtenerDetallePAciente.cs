using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Consultas.ObtenerDetallePaciente;

public class ConsultaObtenerDetallePaciente : IRequest<PacienteDetalleDTO>
{
    public required Guid Id { get; set; }
}
