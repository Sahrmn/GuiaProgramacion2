using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Fahrenheit
        {
            private double _cantidad;

            public Fahrenheit() : this(0)
            { }

            public Fahrenheit(double cant)
            {
                this._cantidad = cant;
            }

            public double GetCantidad()
            {
                return this._cantidad;
            }

            public static explicit operator Celcius(Fahrenheit f)
            {
                double c = (f._cantidad - 32) * 5 / 9;
                Celcius centigrado = new Celcius(c);
                return centigrado;
            }

            public static explicit operator Kelvin(Fahrenheit f)
            {
                double c = (f._cantidad * 459.67) * 5 / 9;
                Kelvin kel = new Kelvin(c);
                return kel;
            }

            public static bool operator ==(Fahrenheit f, Celcius c)
            {
                bool retValue = false;
                Fahrenheit value = (Fahrenheit)c;
                if (f._cantidad == value._cantidad)
                {
                    retValue = true;
                }
                return retValue;
            }

            public static bool operator !=(Fahrenheit f, Celcius c)
            {
                return !(f == c);
            }

            public static bool operator ==(Fahrenheit f, Kelvin k)
            {
                bool retValue = false;
                Fahrenheit value = (Fahrenheit)k;
                if (f._cantidad == value._cantidad)
                {
                    retValue = true;
                }
                return retValue;
            }

            public static bool operator !=(Fahrenheit f, Kelvin k)
            {
                return !(f == k);
            }

            public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
            {
                bool retValue = false;
                if (f1._cantidad == f2._cantidad)
                {
                    retValue = true;
                }
                return retValue;
            }

            public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
            {
                return !(f1 == f2);
            }

            public static Fahrenheit operator +(Fahrenheit f, Celcius c)
            {
                Fahrenheit value = (Fahrenheit)c;
                Fahrenheit retValue = new Fahrenheit(f._cantidad + value._cantidad);
                return retValue;
            }

            public static Fahrenheit operator -(Fahrenheit f, Celcius c)
            {
                Fahrenheit value = (Fahrenheit)c;
                Fahrenheit retValue = new Fahrenheit(f._cantidad - value._cantidad);
                return retValue;
            }

            public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
            {
                Fahrenheit value = (Fahrenheit)k;
                Fahrenheit retValue = new Fahrenheit(f._cantidad + value._cantidad);
                return retValue;
            }

            public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
            {
                Fahrenheit value = (Fahrenheit)k;
                Fahrenheit retValue = new Fahrenheit(f._cantidad - value._cantidad);
                return retValue;
            }

            public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
            {
                Fahrenheit retValue = new Fahrenheit(f1._cantidad + f2._cantidad);
                return retValue;
            }

            public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
            {
                Fahrenheit retValue = new Fahrenheit(f1._cantidad - f2._cantidad);
                return retValue;
            }
        }

    public class Celcius
        {
            private double _cantidad;

            public Celcius() : this(0)
            { }

            public Celcius(double cant)
            {
                this._cantidad = cant;
            }

            public double GetCantidad()
            {
                return this._cantidad;
            }

            public static explicit operator Fahrenheit(Celcius c)
            {
                double f = c._cantidad * (9 / 5) + 32;
                Fahrenheit fahr = new Fahrenheit(f);
                return fahr;
            }

            public static explicit operator Kelvin(Celcius c)
            {
                Fahrenheit conver = (Fahrenheit)c;
                double f = (conver.GetCantidad() + 459.67) * 5 / 9;
                Kelvin kel = new Kelvin(f);
                return kel;
            }

            public static bool operator ==(Celcius c, Fahrenheit f)
            {
                return (f == c);
            }

            public static bool operator !=(Celcius c, Fahrenheit f)
            {
                return !(f == c);
            }

            public static bool operator ==(Celcius c, Kelvin k)
            {
                bool retValue = false;
                Celcius value = (Celcius)k;
                if (c._cantidad == value._cantidad)
                {
                    retValue = true;
                }
                return retValue;
            }

            public static bool operator !=(Celcius c, Kelvin k)
            {
                return !(c == k);
            }

            public static Celcius operator +(Celcius c, Fahrenheit f)
            {
                Celcius value = (Celcius)f;
                Celcius retValue = new Celcius(c._cantidad + value._cantidad);
                return retValue;
            }

            public static Celcius operator -(Celcius c, Fahrenheit f)
            {
                Celcius value = (Celcius)f;
                Celcius retValue = new Celcius(c._cantidad - value._cantidad);
                return retValue;
            }

            public static Celcius operator +(Celcius c, Kelvin k)
            {
                Celcius value = (Celcius)k;
                Celcius retValue = new Celcius(c._cantidad + value._cantidad);
                return retValue;
            }

            public static Celcius operator -(Celcius c, Kelvin k)
            {
                Celcius value = (Celcius)k;
                Celcius retValue = new Celcius(c._cantidad - value._cantidad);
                return retValue;
            }

            public static Celcius operator +(Celcius c1, Celcius c2)
            {
                Celcius retValue = new Celcius(c1._cantidad + c2._cantidad);
                return retValue;
            }

            public static Celcius operator -(Celcius c1, Celcius c2)
            {
                Celcius retValue = new Celcius(c1._cantidad - c2._cantidad);
                return retValue;
            }
        }

    public class Kelvin
        {
            private double _cantidad;

            public Kelvin() : this(0)
            { }

            public Kelvin(double cant)
            {
                this._cantidad = cant;
            }

            public double GetCantidad()
            {
                return this._cantidad;
            }

            public static explicit operator Fahrenheit(Kelvin k)
            {
                double f = k._cantidad * (9 / 5) - 459.67;
                Fahrenheit fahr = new Fahrenheit(f);
                return fahr;
            }

            public static explicit operator Celcius(Kelvin k)
            {
                Fahrenheit conver = (Fahrenheit)k;
                double c = (conver.GetCantidad() - 32) * 5 / 9;
                Celcius centigrados = new Celcius(c);
                return centigrados;
            }

            public static bool operator ==(Kelvin k, Fahrenheit f)
            {
                return (f == k);
            }

            public static bool operator !=(Kelvin k, Fahrenheit f)
            {
                return !(f == k);
            }

            public static bool operator ==(Kelvin k, Celcius c)
            {
                return (c == k);
            }

            public static bool operator !=(Kelvin k, Celcius c)
            {
                return !(c == k);
            }

            public static Kelvin operator +(Kelvin k, Fahrenheit f)
            {
                Kelvin value = (Kelvin)f;
                Kelvin retValue = new Kelvin(k._cantidad + value._cantidad);
                return retValue;
            }

            public static Kelvin operator -(Kelvin k, Fahrenheit f)
            {
                Kelvin value = (Kelvin)f;
                Kelvin retValue = new Kelvin(k._cantidad - value._cantidad);
                return retValue;
            }

            public static Kelvin operator +(Kelvin k, Celcius c)
            {
                Kelvin value = (Kelvin)c;
                Kelvin retValue = new Kelvin(k._cantidad + value._cantidad);
                return retValue;
            }

            public static Kelvin operator -(Kelvin k, Celcius c)
            {
                Kelvin value = (Kelvin)c;
                Kelvin retValue = new Kelvin(k._cantidad - value._cantidad);
                return retValue;
            }

            public static Kelvin operator +(Kelvin k1, Kelvin k2)
            {
                Kelvin retValue = new Kelvin(k1._cantidad + k2._cantidad);
                return retValue;
            }

            public static Kelvin operator -(Kelvin k1, Kelvin k2)
            {
                Kelvin retValue = new Kelvin(k1._cantidad - k2._cantidad);
                return retValue;
            }
        }

}
