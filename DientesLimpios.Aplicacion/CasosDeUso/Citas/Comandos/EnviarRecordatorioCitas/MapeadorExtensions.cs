﻿using DientesLimpios.Aplicacion.Contratos.Notificaciones;
using DientesLimpios.Dominio.Entidades;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.EnviarRecordatorioCitas;

public static class MapeadorExtensions
{
    public static RecordatorioCitaDTO ADto(this Cita cita)
    {
        return new RecordatorioCitaDTO
        {
            Id = cita.Id,
            Fecha = cita.IntervaloDeTiempo.Inicio,
            Paciente = cita.Paciente!.Nombre,
            Paciente_Email = cita.Paciente.Email.Valor,
            Consultorio = cita.Consultorio!.Nombre,
            Dentista = cita.Dentista!.Nombre
        };
    }

}
