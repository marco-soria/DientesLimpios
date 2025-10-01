using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Comandos.CrearDentista;

public class ComandoCrearDentista : IRequest<Guid>
{
    public required string Nombre { get; set; }
    public required string Email { get; set; }
}
