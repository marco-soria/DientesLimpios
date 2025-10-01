namespace DientesLimpios.Dominio.Comunes;

public abstract class EntidadAuditable
{
    public string? CreadoPor { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string? UltimaModificacionPor { get; set; }
    public DateTime? UltimaFechaModificacion { get; set; }
}