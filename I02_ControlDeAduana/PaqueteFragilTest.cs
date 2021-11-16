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
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            //Act
            //Assert
        }

        [TestMethod]
        public void Impuestos_DeberiaRetonarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            PaqueteFragil paquete = new PaqueteFragil("AAAAAA", 150, "Ushuaia", "Salta", 300);
            decimal expected = ((decimal)150 * 35) / 100;

            //Act
            decimal actual = paquete.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil paquete = new PaqueteFragil("11111111", (decimal)23.55, "Guernica", "Avellaneda", 150);
            bool expected = true;
            bool actual;

            //Act
            actual = paquete.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
