﻿using DientesLimpios.Dominio.Excepciones;
using DientesLimpios.Dominio.ObjetosDeValor;

namespace DientesLimpios.Dominio.Entidades;

public class Paciente
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; } = null!;
    public Email Email { get; private set; } = null!;

    private Paciente()
    {

    }

    public Paciente(string nombre, Email email)
    {
        AplicarReglasDeNegocioNombre(nombre);
        AplicarReglasDeNegocioEmail(email);

        Id = Guid.CreateVersion7();
        Nombre = nombre;
        Email = email;
    }

    public void ActualizarNombre(string nombre)
    {
        AplicarReglasDeNegocioNombre(nombre);
        Nombre = nombre;
    }

    private void AplicarReglasDeNegocioNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ExcepcionDeReglaDeNegocio($"El {nameof(nombre)} es obligatorio");
        }
    }

    public void ActualizarEmail(Email email)
    {
        AplicarReglasDeNegocioEmail(email);
        Email = email;
    }

    private void AplicarReglasDeNegocioEmail(Email email)
    {
        if (email is null)
        {
            throw new ExcepcionDeReglaDeNegocio($"El {nameof(email)} es obligatorio");
        }
    }
}