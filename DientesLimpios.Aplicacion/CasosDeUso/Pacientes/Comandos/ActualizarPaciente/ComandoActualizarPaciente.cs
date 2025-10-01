using DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Comandos.CrearPaciente;
using DientesLimpios.Aplicacion.Contratos.Persistencia;
using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Utilidades.Mediador;
using DientesLimpios.Dominio.Entidades;
using DientesLimpios.Dominio.ObjetosDeValor;

namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Comandos.ActualizarPaciente;

public class ComandoActualizarPaciente : IRequest
{
    public required Guid Id { get; set; }
    public required string Nombre { get; set; }
    public required string Email { get; set; }
}