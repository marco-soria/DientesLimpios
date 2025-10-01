using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CompletarCita;

public class ComandoCompletarCita : IRequest
{
    public required Guid Id { get; set; }
}
