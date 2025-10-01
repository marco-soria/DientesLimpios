namespace DientesLimpios.Aplicacion.Utilidades.Mediador;

public interface IRequestHandler<TRequest, TResponse>
            where TRequest : IRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request);
}

public interface IRequestHandler<TRequest>
        where TRequest : IRequest
{
    Task Handle(TRequest request);
}
