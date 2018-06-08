using System;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita();
            Llamada llamada1 = new Local("Moron", 30, "Quilmes", 2.65f);
            Llamada llamada2 = new Provincial("Buenos Aires", Franja.Franja_1, 21, "La Rioja");
            Llamada llamada3 = new Local("Quilmes", 45, "Quilmes", 1.99f);
            Llamada llamada4 = new Provincial(Franja.Franja_3, llamada2);

            Telefonica = Telefonica + llamada1;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += llamada2;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += llamada3;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += llamada3;//repetida
            Console.WriteLine(Telefonica.ToString());
            Telefonica += llamada4;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += llamada4;//repetida
            Console.WriteLine(Telefonica.ToString());

            Console.WriteLine("********* ORDENAMIENTO *********");

            Telefonica.OrdenarLlamadas();
            Console.WriteLine(Telefonica.ToString());
            Console.ReadLine();
        }
    }
}
