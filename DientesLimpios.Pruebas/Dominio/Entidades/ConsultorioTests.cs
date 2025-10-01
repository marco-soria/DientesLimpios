using DientesLimpios.Dominio.Entidades;
using DientesLimpios.Dominio.Excepciones;

namespace DientesLimpios.Pruebas.Dominio.Entidades;

[TestClass]
public class ConsultorioTests
{
    [TestMethod]
    public void Constructor_NombreNulo_LanzaExcepcion()
    {
        Assert.ThrowsExactly<ExcepcionDeReglaDeNegocio>(() => new Consultorio(null!));
    }

}
