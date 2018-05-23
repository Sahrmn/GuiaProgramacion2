using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2205
{
    public class Avion: Vehiculo, IAFIP, IARBA 
    {
        /* Si tengo 2 interfases con un metodo con la misma firma, debo implementar cada metodo de forma explicita
         * y sin el el modificador de visibilidad public y cuando llame al metodo en el main debo castear la interfaz
         * */

        protected double _velocidadMaxima;

        public Avion(double precio, double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double  IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.33;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Avion: " + this._precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.27;
        }
    }
}
