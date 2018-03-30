using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        private static bool resp;

        public static bool ValidaS_N(char c)
        {
            if (c == 's' || c == 'S')
                resp = true;
            else
                resp = false;
            return resp;
        }
    }
}
