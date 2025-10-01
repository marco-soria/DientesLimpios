namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;

public class DentistaListadoDTO
{
    public Guid Id { get; set; }
    public required string Nombre { get; set; }
    public required string Email { get; set; }
}
