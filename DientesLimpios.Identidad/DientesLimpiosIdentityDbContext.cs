using DientesLimpios.Identidad.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DientesLimpios.Identidad;

public class DientesLimpiosIdentityDbContext : IdentityDbContext<Usuario>
{
    public DientesLimpiosIdentityDbContext(DbContextOptions<DientesLimpiosIdentityDbContext> options) :
        base(options)
    {
    }

    protected DientesLimpiosIdentityDbContext()
    {
    }
}
