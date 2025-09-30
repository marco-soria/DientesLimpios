﻿using DientesLimpios.Dominio.Excepciones;
using DientesLimpios.Dominio.ObjetosDeValor;

namespace DientesLimpios.Pruebas.Dominio.ObjetosDeValor;

[TestClass]
public class IntervaloDeTiempoTests
{
    [TestMethod]
    [ExpectedException(typeof(ExcepcionDeReglaDeNegocio))]
    public void Constructor_FechaInicioPosteriorAFechaFin_LanzaExcepcion()
    {
        new IntervaloDeTiempo(DateTime.UtcNow, DateTime.UtcNow.AddDays(-1));
    }

    [TestMethod]
    public void Constructor_ParametrosCorrectos_NoLanzaExcepcion()
    {
        new IntervaloDeTiempo(DateTime.UtcNow, DateTime.UtcNow.AddMinutes(30));
    }
}
