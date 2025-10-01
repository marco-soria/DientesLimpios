using DientesLimpios.Dominio.Enums;

namespace DientesLimpios.Aplicacion.Contratos.Repositorios.Modelos;

public class FiltroCitasDTO
{
    public Guid? PacienteId { get; set; }
    public Guid? DentistaId { get; set; }
    public Guid? ConsultorioId { get; set; }
    public EstadoCita? EstadoCita { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
}