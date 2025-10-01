namespace DientesLimpios.Aplicacion.Contratos.Notificaciones;

public class DatosCorreoCitaDTO
{
    public required Guid Id { get; set; }
    public required string Paciente { get; set; }
    public required string Paciente_Email { get; set; }
    public required string Dentista { get; set; }
    public required string Consultorio { get; set; }
    public required DateTime Fecha { get; set; }
}