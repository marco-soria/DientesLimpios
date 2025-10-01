using FluentValidation;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Comandos.ActualizarConsultorio;

public class ValidadorComandoActualizarConsultorio : AbstractValidator<ComandoActualizarConsultorio>
{
    public ValidadorComandoActualizarConsultorio()
    {
        RuleFor(p => p.Nombre)
        .NotEmpty().WithMessage("El campo {PropertyName} es requerido")
        .MaximumLength(150).WithMessage("La lontigud del campo {PropertyName} debe ser menor o igual a {MaxLength}");
    }
}