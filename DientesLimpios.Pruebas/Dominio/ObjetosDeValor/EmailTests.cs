using DientesLimpios.Dominio.Excepciones;
using DientesLimpios.Dominio.ObjetosDeValor;

namespace DientesLimpios.Pruebas.Dominio.ObjetosDeValor;

[TestClass]
public class EmailTests
{
    [TestMethod]
    public void Constructor_EmailNulo_LanzaExcepcion()
    {
        Assert.ThrowsExactly<ExcepcionDeReglaDeNegocio>(() => new Email(null!));
    }

    [TestMethod]
    public void Constructor_EmailSinArroba_LanzaExcepcion()
    {
        Assert.ThrowsExactly<ExcepcionDeReglaDeNegocio>(() => new Email("admin.com"));
    }

    [TestMethod]
    public void Constructor_EmailValido_NoLanzaExcepcion()
    {
        new Email("admin@ejemplo.com");
    }


}
