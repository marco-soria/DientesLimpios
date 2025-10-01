namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerDetalleDentista;

public class DentistaDTO
{
    public Guid Id { get; set; }
    public required string Nombre { get; set; }
    public required string Email { get; set; }
}
