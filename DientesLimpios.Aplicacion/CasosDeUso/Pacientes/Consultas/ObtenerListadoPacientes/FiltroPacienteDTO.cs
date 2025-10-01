namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Consultas.ObtenerListadoPacientes;

public class FiltroPacienteDTO
{
    public int Pagina { get; set; } = 1;
    public int RegistrosPorPagina { get; set; } = 10;
    public string? Nombre { get; set; }
    public string? Email { get; set; }
}