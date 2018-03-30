using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            string nombre;
            float vHora;
            int antiguedad;
            int horasTrab;
            double total = 0, totalFinal = 0;
            int j;
            string msj = "";

            Console.WriteLine("EMPLEADOS\n");
            while (resp != "n")
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Valor por hora: ");
                vHora = int.Parse(Console.ReadLine());
                Console.Write("Antiguedad:(años): ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                horasTrab = int.Parse(Console.ReadLine());

                total = (vHora * horasTrab) + (antiguedad * 150);
                total = total * 0.87;
                totalFinal += total;
                for (j = 0; j < nombre.Length + 4; j++)
                {
                    msj += "=";
                }
                msj += "\n";
                msj += "||";
                msj += nombre;
                msj += "||\n";
                for (j = 0; j < nombre.Length + 4; j++)
                {
                    msj += "=";
                }
                msj += "\n";
                Console.Write(msj);
                Console.WriteLine("||Antiguedad: {0} || Valor p/hora: {1} ||\n", antiguedad, vHora);
                Console.WriteLine("|| Total a cobrar: {0:0.0} || Descuentos: {1:0.0} ||\n", total, total * 0.13);
                Console.Write("¿Cargar otro empleado?[s/n]: ");
                resp = Console.ReadLine();
                Console.WriteLine("\n");
                msj = "";
            }
            Console.WriteLine("TOTAL NETO A PAGAR: {0:0.00}",totalFinal);
            Console.ReadLine();
        }
    }
}
