﻿using DientesLimpios.Aplicacion.Contratos.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace DientesLimpios.Persistencia.Repositorios;

public class Repositorio<T> : IRepositorio<T> where T : class
{
    private readonly DientesLimpiosDbContext context;

    public Repositorio(DientesLimpiosDbContext context)
    {
        this.context = context;
    }

    public Task Actualizar(T entidad)
    {
        context.Update(entidad);
        return Task.CompletedTask;
    }

    public Task<T> Agregar(T entidad)
    {
        context.Add(entidad);
        return Task.FromResult(entidad);
    }

    public Task Borrar(T entidad)
    {
        context.Remove(entidad);
        return Task.CompletedTask;
    }

    public async Task<T?> ObtenerPorId(Guid id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> ObtenerTodos()
    {
        return await context.Set<T>().ToListAsync();
    }
}
