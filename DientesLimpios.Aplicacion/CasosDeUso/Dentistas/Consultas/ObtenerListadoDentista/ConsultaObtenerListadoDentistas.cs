using DientesLimpios.Aplicacion.Utilidades.Comunes;
using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;

public class ConsultaObtenerListadoDentistas : FiltroDentistasDTO, IRequest<PaginadoDTO<DentistaListadoDTO>>
{
}
