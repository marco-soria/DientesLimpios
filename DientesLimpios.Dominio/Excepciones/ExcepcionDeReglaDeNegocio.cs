namespace DientesLimpios.Dominio.Excepciones;

public class ExcepcionDeReglaDeNegocio : Exception
{
    public ExcepcionDeReglaDeNegocio(string mensaje)
        : base(mensaje)
    {

    }
}
