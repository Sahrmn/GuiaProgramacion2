using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2205
{
    public abstract class Auto: Vehiculo
    {
        protected string _patente;

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        public Auto(double precio, string patente):base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();
    }
}
