using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.ControlDeAduana;

namespace PruebasUnitarias
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitalAfip()
        {

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestosDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            PaquetePesado paquete = new PaquetePesado("AAAAAA", 150, "Ushuaia", "Salta", 300);
            decimal expected = ((decimal)150 * 35) / 100;

            //Act
            decimal actual = paquete.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange
            Paquete paquete = new PaquetePesado("AAAAAAA", (decimal)75.25,"Rosario","Buenos Aires", 178);
            bool expected = false;
            bool actual;

            //Act
            actual = paquete.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
