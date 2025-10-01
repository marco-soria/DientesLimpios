using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Consultas.ObtenerDetalleConsultorio;

public class ConsultaObtenerDetalleConsultorio : IRequest<ConsultorioDetalleDTO>
{
    public Guid Id { get; set; }
}
