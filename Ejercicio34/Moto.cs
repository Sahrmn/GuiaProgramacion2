using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio34
{
    public class Moto: VehiculoTerrestre
    {
        public short _cilindrada;

        public Moto(short cil, short ruedas, short puertas, EColores color):base(ruedas, puertas, color)
        {
            this._cilindrada = cil;
        }
    }
}
