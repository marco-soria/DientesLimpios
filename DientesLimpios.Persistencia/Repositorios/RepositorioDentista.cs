using DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentista;
using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Dominio.Entidades;
using DientesLimpios.Persistencia.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace DientesLimpios.Persistencia.Repositorios;

public class RepositorioDentista : Repositorio<Dentista>, IRepositorioDentista
{
    private readonly DientesLimpiosDbContext context;

    public RepositorioDentista(DientesLimpiosDbContext context)
            : base(context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<Dentista>> ObtenerFiltrado(FiltroDentistasDTO filtro)
    {
        var queryable = context.Dentistas.AsQueryable();

        if (!string.IsNullOrWhiteSpace(filtro.Nombre))
        {
            queryable = queryable.Where(x => x.Nombre.Contains(filtro.Nombre));
        }

        if (!string.IsNullOrWhiteSpace(filtro.Email))
        {
            queryable = queryable.Where(x => x.Email.Valor.Contains(filtro.Email));
        }

        return await queryable.OrderBy(x => x.Nombre).Paginar(filtro.Pagina, filtro.RegistrosPorPagina).ToListAsync();
    }
}
