using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Verifica que la lista de Paquetes del Correo esté instanciada
        /// </summary>
        [TestMethod]
        public void PaquetesCorrectos()
        {
            //Paquete nuevoPaquete = new Paquete("dir1", "0000");
            Correo unCorreo = new Correo();
            Assert.IsNotNull(unCorreo.Paquetes);
        }


        /// <summary>
        /// Verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID
        /// </summary>
        [TestMethod]
        public void AgregarPaquetesMismoTracking()
        {
            Paquete paq1 = new Paquete("Dir1", "000");
            Paquete paq2 = new Paquete("Dir2", "000");
            Correo unCorreo = new Correo();
            try
            {
                unCorreo += paq1;
                unCorreo += paq2;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
            
        }
    }
}
