using DientesLimpios.Aplicacion.Contratos.Persistencia;
using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Utilidades.Mediador;
using DientesLimpios.Aplicacion.Excepciones;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Comandos.ActualizarConsultorio;

public class CasoDeUsoActualizarConsultorio : IRequestHandler<ComandoActualizarConsultorio>
{
    private readonly IRepositorioConsultorios repositorio;
    private readonly IUnidadDeTrabajo unidadDeTrabajo;

    public CasoDeUsoActualizarConsultorio(IRepositorioConsultorios repositorio,
        IUnidadDeTrabajo unidadDeTrabajo)
    {
        this.repositorio = repositorio;
        this.unidadDeTrabajo = unidadDeTrabajo;
    }

    public async Task Handle(ComandoActualizarConsultorio request)
    {
        var consultorio = await repositorio.ObtenerPorId(request.Id);

        if (consultorio is null)
        {
            throw new ExcepcionNoEncontrado();
        }

        consultorio.ActualizarNombre(request.Nombre);

        try
        {
            await repositorio.Actualizar(consultorio);
            await unidadDeTrabajo.Persistir();
        }
        catch (Exception)
        {
            await unidadDeTrabajo.Reversar();
            throw;
        }

    }
}
