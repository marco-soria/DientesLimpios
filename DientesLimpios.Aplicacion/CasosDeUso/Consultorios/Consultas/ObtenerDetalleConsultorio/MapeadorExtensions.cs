using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Consultas.ObtenerDetalleConsultorio;

public static class MapeadorExtensions
{
    public static ConsultorioDetalleDTO ADto(this Consultorio consultorio)
    {
        var dto = new ConsultorioDetalleDTO { Id = consultorio.Id, Nombre = consultorio.Nombre };
        return dto;
    }
}
