using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ejercicio31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        public enum EPuesto { Caja1, Caja2};
        private EPuesto _puesto;

        public static int NumeroActual
        {
            get {
                numeroActual++;
                return numeroActual; }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto):this()
        {
            this._puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(100);
            return true;
        }
    }
}
