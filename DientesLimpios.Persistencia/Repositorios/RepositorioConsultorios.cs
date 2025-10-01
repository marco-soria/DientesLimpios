using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Persistencia.Repositorios;

public class RepositorioConsultorios : Repositorio<Consultorio>, IRepositorioConsultorios
{
    public RepositorioConsultorios(DientesLimpiosDbContext context)
        : base(context)
    {

    }
}
