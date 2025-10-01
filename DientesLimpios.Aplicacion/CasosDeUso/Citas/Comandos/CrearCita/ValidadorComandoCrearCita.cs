using FluentValidation;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CrearCita;

public class ValidadorComandoCrearCita : AbstractValidator<ComandoCrearCita>
{
    public ValidadorComandoCrearCita()
    {
        RuleFor(x => x.FechaInicio)
        .GreaterThan(x => x.FechaFin).WithMessage("La fecha fin debe ser posterior a la fecha de inicio")
        .GreaterThan(DateTime.UtcNow).WithMessage("La fecha inicio no puede estar en el pasado");

    }
}