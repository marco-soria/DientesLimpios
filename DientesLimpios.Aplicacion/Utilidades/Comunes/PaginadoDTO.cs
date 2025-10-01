namespace DientesLimpios.Aplicacion.Utilidades.Comunes;

public class PaginadoDTO<T>
{
    public List<T> Elementos { get; set; } = [];
    public int Total { get; set; }
}
