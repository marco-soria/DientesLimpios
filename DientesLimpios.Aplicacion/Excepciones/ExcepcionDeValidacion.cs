﻿using FluentValidation.Results;

namespace DientesLimpios.Aplicacion.Excepciones;

public class ExcepcionDeValidacion : Exception
{
    public List<string> ErroresDeValidacion { get; set; } = [];

    public ExcepcionDeValidacion(string mensajeDeError)
    {
        ErroresDeValidacion.Add(mensajeDeError);
    }

    public ExcepcionDeValidacion(ValidationResult validationResult)
    {
        foreach (var errorDeValidacion in validationResult.Errors)
        {
            ErroresDeValidacion.Add(errorDeValidacion.ErrorMessage);
        }
    }
}