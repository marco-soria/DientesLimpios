using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Consultas.ObtenerListadoConsultorios;

public static class MapeadorExtensions
{
    public static ConsultorioListadoDTO ADto(this Consultorio consultorio)
    {
        var dto = new ConsultorioListadoDTO { Id = consultorio.Id, Nombre = consultorio.Nombre };
        return dto;
    }
}