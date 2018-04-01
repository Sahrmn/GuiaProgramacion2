using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <param name="lado"></param>
        /// <returns></returns>
        public static double CalcularCuadrado(double lado)
        {
            double respuesta = Math.Pow(lado, 2);
            return respuesta;
        }

        /// <summary>
        /// Calcula el area de un triangulo
        /// </summary>
        /// <param name="thebase"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static double CalcularTriangulo(double thebase, double altura)
        {
            double respuesta = (thebase * altura)/2;
            return respuesta;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns>
        public static double CalcularCirculo(double radio)
        {
            double respuesta = Math.PI * Math.Pow(radio,2);
            return respuesta;
        }
    }
}
