using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double _cantidad;
        public static float cotizRespectoDolar = 1;

        public Dolar(double cant)
        {
            this._cantidad = cant;
            //Dolar.cotizRespectoDolar = 1;
        }

        public Dolar() : this(0)
        { }

        public Dolar(double cant, float cotizacion) : this(cant)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro retValue = new Euro((d._cantidad * Euro.cotizRespectoDolar));
            return retValue;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos retValue = new Pesos(d._cantidad * Pesos.cotizRespectoDolar);
            return retValue;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar retValue = new Dolar(d * Dolar.cotizRespectoDolar);
            return retValue;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retValue = false;
            Dolar unDolar = (Dolar)e;
            if (d.GetCantidad() == unDolar.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retValue = false;
            Dolar unDolar = (Dolar)p;
            if (d.GetCantidad() == unDolar.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retValue = false;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar unDolar = (Dolar)e;
            Dolar retValue = new Dolar(d.GetCantidad() - unDolar.GetCantidad());
            return retValue;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar unDolar = (Dolar)e;
            Dolar retValue = new Dolar(d.GetCantidad() + unDolar.GetCantidad());
            return retValue;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar unDolar = (Dolar)p;
            Dolar retValue = new Dolar(d.GetCantidad() - unDolar.GetCantidad());
            return retValue;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar unDolar = (Dolar)p;
            Dolar retValue = new Dolar(d.GetCantidad() + unDolar.GetCantidad());
            return retValue;
        }

    }

    public class Euro
    {
        private double _cantidad;
        public static float cotizRespectoDolar = 0.80f;

        public Euro(double cant)
        {
            this._cantidad = cant;
            //Euro.cotizRespectoDolar = 0.73f;
        }

        public Euro() : this(0)
        { }

        public Euro(double cant, float cotizacion) : this(cant)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar retValue = new Dolar(e._cantidad / Euro.cotizRespectoDolar);
            return retValue;
        }

        public static explicit operator Pesos(Euro e)
        {
            double value = e._cantidad / Euro.cotizRespectoDolar;
            Pesos retValue = new Pesos(value * Pesos.cotizRespectoDolar);
            return retValue;
        }

        public static implicit operator Euro(double d)
        {
            Euro retValue = new Euro(d);
            return retValue;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (d == e);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retValue = false;
            Euro unEuro = (Euro)p;
            if (e.GetCantidad() == unEuro.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retValue = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro unEuro = (Euro)d;
            Euro retValue = new Euro(e.GetCantidad() - unEuro.GetCantidad());
            return retValue;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro unEuro = (Euro)d;
            Euro retValue = new Euro(e.GetCantidad() + unEuro.GetCantidad());
            return retValue;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro unEuro = (Euro)p;
            Euro retValue = new Euro(e.GetCantidad() - unEuro.GetCantidad());
            return retValue;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro unEuro = (Euro)p;
            Euro retValue = new Euro(e.GetCantidad() + unEuro.GetCantidad());
            return retValue;
        }
    }

    public class Pesos
    {
        private double _cantidad;
        public static float cotizRespectoDolar = 20.18f;

        public Pesos(double cant)
        {
            this._cantidad = cant;
            //Pesos.cotizRespectoDolar = 17.55f;
        }

        public Pesos() : this(0)
        { }

        public Pesos(double cant, float cotizacion) : this(cant)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar retValue = new Dolar(p._cantidad / Pesos.cotizRespectoDolar);
            return retValue;
        }

        public static explicit operator Euro(Pesos p)
        {
            double value = (p._cantidad / Pesos.cotizRespectoDolar);
            Euro retValue = new Euro(value * Euro.cotizRespectoDolar);
            return retValue;
        }

        //

        public static implicit operator Pesos(double d)
        {
            Pesos retValue = new Pesos(d);
            return retValue;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return (d == p);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return (e == p);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retValue = false;
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos unPeso = (Pesos)d;
            Pesos retValue = new Pesos(p.GetCantidad() - unPeso.GetCantidad());
            return retValue;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos unPeso = (Pesos)d;
            Pesos retValue = new Pesos(p.GetCantidad() + unPeso.GetCantidad());
            return retValue;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos unPeso = (Pesos)e;
            Pesos retValue = new Pesos(p.GetCantidad() - unPeso.GetCantidad());
            return retValue;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos unPeso = (Pesos)e;
            Pesos retValue = new Pesos(p.GetCantidad() + unPeso.GetCantidad());
            return retValue;
        }
    }
}
