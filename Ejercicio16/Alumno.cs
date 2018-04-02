using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        /// <summary>
        /// Ingreso de notas
        /// </summary>
        /// <param name="nota1"></param>
        /// <param name="nota2"></param>
        public void Estudiar (byte nota1, byte nota2)
        {
            _nota1 = nota1;
            _nota2 = nota2;
            this.CalcularFinal();
        }

        /// <summary>
        /// Calculo de la nota final a partir de las 2 notas
        /// </summary>
        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random rnd = new Random();
                if (this._nota2 < this._nota1)
                {
                    this._notaFinal = rnd.Next(_nota2, _nota1);
                }
                else
                    this._notaFinal = rnd.Next(_nota1, _nota2);
            }
            else
                this._notaFinal = -1;
        }

        /// <summary>
        /// Muestra los datos del alumno
        /// </summary>
        public void Mostar()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Alumno {0} {1}",apellido,nombre);
            Console.WriteLine("Legajo {0}",legajo);
            Console.WriteLine("Nota 1: {0} \nNota2: {1}",this._nota1,this._nota2);
            if (this._notaFinal != -1)
                Console.WriteLine("Nota Final: {0}", this._notaFinal);
            else
                Console.WriteLine("Alumno desaprobado");
        }
    }
}
