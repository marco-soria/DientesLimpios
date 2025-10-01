using DientesLimpios.Aplicacion.Contratos.Repositorios.Modelos;
using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Consultas.ObtenerListadoCitas;

public class ConsultaObtenerListadoCitas : FiltroCitasDTO, IRequest<List<CitaListadoDTO>>
{
}
