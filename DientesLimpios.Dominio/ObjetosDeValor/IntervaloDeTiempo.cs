using DientesLimpios.Dominio.Excepciones;

namespace DientesLimpios.Dominio.ObjetosDeValor;

public record IntervaloDeTiempo
{
    public DateTime Inicio { get; }
    public DateTime Fin { get; }

    private IntervaloDeTiempo()
    {

    }

    public IntervaloDeTiempo(DateTime inicio, DateTime fin)
    {
        if (inicio >= fin)
        {
            throw new ExcepcionDeReglaDeNegocio("La hora de inicio debe ser anterior a la hora de fin.");
        }

        Inicio = inicio;
        Fin = fin;
    }
}