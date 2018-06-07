using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio34
{
    public class Camion: VehiculoTerrestre
    {
        public short _cantidadMarchas;
        public int _pesoCarga;

        public Camion(short marchas, int pesoCarga, short ruedas, short puertas, EColores color):base(ruedas, puertas, color)
        {
            this._cantidadMarchas = marchas;
            this._pesoCarga = pesoCarga;
        }
    }
}
