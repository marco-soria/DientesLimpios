﻿using DientesLimpios.Aplicacion.Contratos.Persistencia;
using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Excepciones;
using DientesLimpios.Aplicacion.Utilidades.Mediador;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CompletarCita;

public class CasoDeUsoCompletarCita : IRequestHandler<ComandoCompletarCita>
{
    private readonly IRepositorioCitas repositorio;
    private readonly IUnidadDeTrabajo unidadDeTrabajo;

    public CasoDeUsoCompletarCita(IRepositorioCitas repositorio, IUnidadDeTrabajo unidadDeTrabajo)
    {
        this.repositorio = repositorio;
        this.unidadDeTrabajo = unidadDeTrabajo;
    }

    public async Task Handle(ComandoCompletarCita request)
    {
        var cita = await repositorio.ObtenerPorId(request.Id);

        if (cita is null)
        {
            throw new ExcepcionNoEncontrado();
        }

        cita.Completar();

        try
        {
            await repositorio.Actualizar(cita);
            await unidadDeTrabajo.Persistir();
        }
        catch (Exception)
        {
            await unidadDeTrabajo.Reversar();
            throw;
        }
    }
}