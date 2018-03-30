using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{
    class Validacion
    {
        private static bool resp = false;
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min || valor > max)
                resp = false;
            else
                resp = true;
            return resp;
        }
    }
}
