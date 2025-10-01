namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;

public class FiltroDentistasDTO
{
    public int Pagina { get; set; } = 1;
    public int RegistrosPorPagina { get; set; } = 10;
    public string? Nombre { get; set; }
    public string? Email { get; set; }
}
