using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        protected int _numero;
        
        public int Numeros
        {
            get { return this._numero; }
        }

        public Numero(int n)
        {
            this._numero = n;
        }

        public static int operator +(Numero num1, Numero num2)
        {
            return num1 + num2;
        }

        public static int operator -(Numero num1, Numero num2)
        {
            return num1 - num2;
        }

        public static int operator *(Numero num1, Numero num2)
        {
            return num1 * num2;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            return num1 / num2;
        }

        public static bool Parse(string a, out Numero n)
        {
            bool retValue = true;
            int b = 0;
            try
            {
                b = int.Parse(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retValue = false;
            }
            n = new Numero(b);
            return retValue;
        }

    }
}
