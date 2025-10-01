using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Comandos.BorrarDentista;

public class ComandoBorrarDentista : IRequest
{
    public Guid Id { get; set; }
}