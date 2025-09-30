﻿using DientesLimpios.Dominio.Entidades;
using DientesLimpios.Dominio.Excepciones;
using DientesLimpios.Dominio.ObjetosDeValor;

namespace DientesLimpios.Pruebas.Dominio.Entidades;

[TestClass]
public class DentistaTests
{
    [TestMethod]
    [ExpectedException(typeof(ExcepcionDeReglaDeNegocio))]
    public void Constructor_NombreNulo_LanzaExcepcion()
    {
        var email = new Email("felipe@ejemplo.com");
        new Dentista(null!, email);
    }

    [TestMethod]
    [ExpectedException(typeof(ExcepcionDeReglaDeNegocio))]
    public void Constructor_EmailNulo_LanzaExcepcion()
    {
        Email email = null!;
        new Dentista("Felipe", email);
    }
}
