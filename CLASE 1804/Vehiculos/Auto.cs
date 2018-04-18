using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        //public string MostrarAuto()
        //{
        //    return base.Mostrar() + "\nCantidad de Asientos: " + this._cantidadAsientos + "\nTara: " + this._tara + "\nCilindrada:" + this._cilindrada;
        //}

        public Auto(string patente,byte ruedas, EMarcas marca, int cantAsientos, float tara, float cilindrada):base(patente, ruedas, marca)
        {
            this._cantidadAsientos = cantAsientos;
            this._tara = tara;
            this._cilindrada = cilindrada;
        }

        protected override string Mostrar()
        {
            return "AUTO\n" + base.Mostrar() + "\nCantidad de Asientos: " + this._cantidadAsientos + "\nTara: " + this._tara + "\nCilindrada:" + this._cilindrada + "\n" + this.Acelerar();
        }

        public override string ToString()//hacer siempre
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retValue = false;

            if (obj is Auto)
            {
                //si son iguales, verificar si la marca y la patente son iguales, si son iguales -> true, sino false

                if ((Vehiculo)obj == this)
                {
                    retValue = true;
                }
                
            }
            return retValue;
        }

        public override string Acelerar()
        {
            return "El auto esta acelerando";
        }
    }
}
