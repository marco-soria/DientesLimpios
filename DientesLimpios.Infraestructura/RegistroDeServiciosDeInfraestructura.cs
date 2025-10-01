using DientesLimpios.Aplicacion.Contratos.Notificaciones;
using DientesLimpios.Infraestructura.Notificaciones;
using Microsoft.Extensions.DependencyInjection;

namespace DientesLimpios.Infraestructura;

public static class RegistroDeServiciosDeInfraestructura
{
    public static IServiceCollection AgregarServiciosDeInfraestructura(this IServiceCollection services)
    {
        services.AddScoped<IServicioNotificaciones, ServicioCorreos>();
        return services;
    }
}
