namespace DientesLimpios.Aplicacion.Utilidades.Mediador;

public interface IMediator
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
}
