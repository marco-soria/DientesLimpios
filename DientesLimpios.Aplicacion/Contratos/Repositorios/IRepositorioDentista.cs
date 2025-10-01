using DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;
using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.Contratos.Repositorios;

public interface IRepositorioDentista : IRepositorio<Dentista>
{
    Task<IEnumerable<Dentista>> ObtenerFiltrado(FiltroDentistasDTO filtro);
}
