using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;

public static class MapeadorExtensions
{
    public static DentistaListadoDTO ADto(this Dentista Dentista)
    {
        var dto = new DentistaListadoDTO { Id = Dentista.Id, Nombre = Dentista.Nombre, Email = Dentista.Email.Valor };
        return dto;
    }
}