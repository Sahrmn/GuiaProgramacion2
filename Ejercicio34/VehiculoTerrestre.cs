using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio34
{
    public abstract class VehiculoTerrestre
    {
        public short _cantidadRuedas;
        public short _cantidadPuertas;
        public EColores _color;

        public VehiculoTerrestre(short ruedas, short puertas, EColores color)
        {
            this._cantidadRuedas = ruedas;
            this._cantidadPuertas = puertas;
            this._color = color;
        }
    }
}
