using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerDetalleDentista;

public static class MapeadorExtensions
{
    public static DentistaDTO ADto(this Dentista dentista)
    {
        var dto = new DentistaDTO { Id = dentista.Id, Nombre = dentista.Nombre, Email = dentista.Email.Valor };
        return dto;
    }
}
