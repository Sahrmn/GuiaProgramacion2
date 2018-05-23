using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregadoListaNumeros()
        {
            ColectoraDeNumeros colectora = new ColectoraDeNumeros(ETipoNumero.Par);
            Numero num1 = new Numero(8);
            //ColectoraDeNumeros nuevaColectora = new ColectoraDeNumeros(colectora.Tipo);
            try
            {
                colectora = colectora + num1;
                Numero num2 = new Numero(-1);
                colectora += num2;
                Numero num3 = new Numero(0);
                colectora += num3;
                Numero num4 = null;
                colectora += num4;
                colectora += num2; //agrego de nuevo
            }
            catch (Exception e)
            { 
                //Assert.Fail()
            }
        }

        
    }
}
