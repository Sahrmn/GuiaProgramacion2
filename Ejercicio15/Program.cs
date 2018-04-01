using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Mostrar(Calculadora.Calcular(2, 5, '*'));
            Calculadora.Mostrar(Calculadora.Calcular(5,0,'/'));
            Calculadora.Mostrar(Calculadora.Calcular(10, 5, '/'));
            Calculadora.Mostrar(Calculadora.Calcular(10, 20, '+'));
            Calculadora.Mostrar(Calculadora.Calcular(55, 20, '-'));
        }
    }
}
