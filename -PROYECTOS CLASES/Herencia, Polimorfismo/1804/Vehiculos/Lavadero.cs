using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        public enum EVehiculos { Auto, Moto, Camion };

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="precioA">Precio para autos</param>
        /// <param name="precioC">Precio para camiones</param>
        /// <param name="precioM">Precio para motos</param>
        public Lavadero(List<Vehiculo> listaV, float precioA, float precioC, float precioM):this()
        {
            this._vehiculos = listaV;
            this._precioAuto = precioA;
            this._precioCamion = precioC;
            this._precioMoto = precioM;
        }

        public string MiLavadero
        {
            get { return "**************************\n" + "Precio Autos: " + this._precioAuto + "\nPrecio Camiones: " + this._precioCamion + "\nPrecio Motos: " + this._precioMoto + "\n\n" + this.VerVehiculos; }
        }

        public string VerVehiculos
        {
            get {
                string retValue = "";
                foreach (Vehiculo item in this._vehiculos)
                {
                    retValue += "\n-----------------------------";
                    retValue += item.ToString();
                }
                return retValue;
            }
        }

        /// <summary>
        /// Retorna TRUE si el vehiculo esta en el lavadero
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool retValue = false;
            
            foreach (Vehiculo item in l._vehiculos)
            {
                if (v == item)
                {
                    retValue = true;
                }
            }
            return retValue;
        }

        /// <summary>
        /// Retorna TRUE si el vehiculo no esta en el lavadero
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        /// <summary>
        /// Agrega un vehiculo al lavadero si es que este no se encuentra en el lavadero
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (l != v)
            {
                l._vehiculos.Add(v);
            }
            return l;
        }

        /// <summary>
        /// Remueve un vehiculo del lavadero si se encuentra en el lavadero
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l._vehiculos.Remove(v);
            }
            return l;   
        }

        public double MostrarTotalFacturado(EVehiculos v)
        {
            int count = 0;
            int subV = (int)v;
            double retValue = 1;

            switch (subV)
            {
                case 0://Auto
                    foreach (Vehiculo item in this._vehiculos)
                    {
                        if (item is Auto)
                            count++;
                    }
                    retValue = count * this._precioAuto;
                    break;
                case 1://Moto
                    foreach (Vehiculo item in this._vehiculos)
                    {
                        if (item is Moto)
                            count++;
                    }
                    retValue = count * this._precioMoto;
                    break;
                case 2://Camion
                    foreach (Vehiculo item in this._vehiculos)
                    {
                        if (item is Camion)
                            count++;
                    }
                    retValue = count * this._precioCamion;
                    break;
                default:
                    retValue = -1;
                    break;
            }
            return retValue;
        }

        public double MostrarTotalFacturado()
        {
            double retValue = this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
            return retValue;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int retValue = 0;
            if (v1.GetPatente.CompareTo(v2.GetPatente) < 0)
                retValue = -1;
            else if (v1.GetPatente.CompareTo(v2.GetPatente) > 0)
                retValue = 1;
            return retValue;
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            int retValue = 0;
            if (v1.GetMarca > v2.GetMarca)
                retValue = 1;
            else if (v1.GetMarca < v2.GetMarca)
                retValue = -1;
            return retValue;
        }

        /// <summary>
        /// Ordena los vehiculos
        /// </summary>
        /// <param name="a">1 para ordenar por patente, otro para ordenar por marca</param>
        public void Ordenar(int a)
        {
            if (a == 1)
            {
                this._vehiculos.Sort(OrdenarVehiculosPorPatente);
            }
            else
                this._vehiculos.Sort(OrdenarVehiculosPorMarca);
        }
    }
}
