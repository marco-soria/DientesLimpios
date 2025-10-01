using DientesLimpios.Aplicacion.Contratos.Identidad;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DientesLimpios.Identidad.Servicios;

public class ServicioUsuarios : IServicioUsuarios
{
    private readonly IHttpContextAccessor httpContextAccessor;

    public ServicioUsuarios(IHttpContextAccessor httpContextAccessor)
    {
        this.httpContextAccessor = httpContextAccessor;
    }

    public string ObtenerUsuarioId()
    {
        return httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)!;
    }
}
