namespace DientesLimpios.Aplicacion.Contratos.Persistencia;

public interface IUnidadDeTrabajo
{
    Task Persistir();
    Task Reversar();
}
