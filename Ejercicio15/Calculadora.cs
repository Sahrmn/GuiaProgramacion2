using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio15
{
    class Calculadora
    {
        public static float Calcular(int num1, int num2, char operacion)
        {
            float respuesta = 0;
            bool validacion = true;

            switch (operacion)
            {
                case '+':
                    respuesta = num1 + num2;
                    break;
                case '-':
                    respuesta = num1 - num2;
                    break;
                case '*':
                    respuesta = num1 * num2;
                    break;
                case '/':
                    validacion = Validar(num2);
                    if (validacion == true)
                    {
                        respuesta = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero!");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("No es una operacion posible!");
                    Console.ReadLine();
                    break;
            }
            return respuesta;
        }

        private static bool Validar(int num2)
        {
            bool resp = true;
            if (num2 == 0)
            {
                resp = false; 
            }
            return resp;
        }

        public static void Mostrar(float respuesta)
        {
            Console.WriteLine("Respuesta {0,5}",respuesta);
            Console.ReadLine();
        }
    }
}
