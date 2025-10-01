namespace DientesLimpios.Aplicacion.Contratos.Notificaciones;

public interface IServicioNotificaciones
{
    Task EnviarConfirmacionCita(ConfirmacionCitaDTO cita);
    Task EnviarRecordatorioCita(RecordatorioCitaDTO cita);
}
