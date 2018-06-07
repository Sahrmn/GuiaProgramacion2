using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio34
{
    public class Automovil: VehiculoTerrestre
    {
        public short _cantidadMarchas;
        public int _cantidadPasajeros;

        public Automovil(short marchas, int pasajeros, short ruedas, short puertas, EColores color):base(ruedas, puertas, color)
        {
            this._cantidadMarchas = marchas;
            this._cantidadPasajeros = pasajeros;
        }
    }
}
