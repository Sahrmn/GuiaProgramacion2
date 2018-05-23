using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Verificadora
    {
        public static bool VerificarNumero(ETipoNumero tipo, Numero num)
        {
            bool retValue = false;
            switch (tipo)
            {
                case ETipoNumero.Par:
                    if ((num.Numeros % 2) == 0)
                    {
                        retValue = true;
                    }
                    break;
                case ETipoNumero.Impar:
                    if ((num.Numeros % 2) != 0)
                    {
                        retValue = true;
                    }
                    break;
                case ETipoNumero.Positivo:
                    if (num.Numeros > 0)
                    {
                        retValue = true;
                    }
                    break;
                case ETipoNumero.Negativo:
                    if (num.Numeros < 0)
                    {
                        retValue = true;
                    }
                    break;
                case ETipoNumero.Cero:
                    if (num.Numeros == 0)
                    {
                        retValue = true;
                    }
                    break;
                default:
                    break;
            }
            return retValue;
        }
    }
}
