using System;
using Biblioteca2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Biblioteca2017.PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var libro = Libro.Registrar("Libro de Prueba");
            var usuario = Usuario.Registrar("Usuario nuevo");
            libro.Valorar(usuario, 5);
            //Si yo regitro una valoracion de un libro
            //La propiedad Valoraciones debe tener al menos una valoracion
            Assert.IsTrue(libro.Valoraciones.Count > 0);
        }
    }
}
