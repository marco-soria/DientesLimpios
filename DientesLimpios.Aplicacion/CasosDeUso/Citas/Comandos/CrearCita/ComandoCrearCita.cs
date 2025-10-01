using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CrearCita;

public class ComandoCrearCita : IRequest<Guid>
{
    public Guid PacienteId { get; set; }
    public Guid DentistaId { get; set; }
    public Guid ConsultorioId { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
}