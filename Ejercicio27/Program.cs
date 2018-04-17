using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Pila
            //Stack<int> pilaNum = new Stack<int>(20);
            int verif = 0;
            Random rand = new Random();
            /*
            for (int i = 0; i < 20; i++)
            {
                verif = rand.Next(-100, 100);
                while (verif == 0)
                {
                    verif = rand.Next(-100, 100);
                }
                pilaNum.Push(verif);
            }
            foreach (int item in pilaNum)
            {
                Console.WriteLine(item);
            }

            //ordeno
            int[] pilaOrdenada = pilaNum.ToArray();
            int aux = 0;

            for (int i = 1; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (pilaOrdenada[i] < pilaOrdenada[j])
                    {
                        aux = pilaOrdenada[i];
                        pilaOrdenada[i] = pilaOrdenada[j];
                        pilaOrdenada[j] = aux;
                    }

                }
            }

            Console.WriteLine("\nElementos positivos\n");
            for (int i = 19; i > 0; i--)
            {
                if (pilaOrdenada[i] > 0)
                {
                    Console.WriteLine(pilaOrdenada[i]);
                }
            }
            Console.WriteLine("\nElementos negativos\n");
            foreach (int item in pilaOrdenada)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();*/
            #endregion
            /*
            Queue<int> colaNum = new Queue<int>(20);

            for (int i = 0; i < 20; i++)
            {
                verif = rand.Next(-300, 300);
                while (verif == 0)
                {
                    verif = rand.Next(-100, 100);
                }
                colaNum.Enqueue(verif);
            }
            foreach (int item in colaNum)
            {
                Console.WriteLine(item);
            }

            //ordeno
            int[] pilaOrdenada = colaNum.ToArray();
            int aux = 0;

            for (int i = 1; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (pilaOrdenada[i] < pilaOrdenada[j])
                    {
                        aux = pilaOrdenada[i];
                        pilaOrdenada[i] = pilaOrdenada[j];
                        pilaOrdenada[j] = aux;
                    }

                }
            }

            Console.WriteLine("\nElementos positivos\n");
            for (int i = 19; i > 0; i--)
            {
                if (pilaOrdenada[i] > 0)
                {
                    Console.WriteLine(pilaOrdenada[i]);
                }
            }
            Console.WriteLine("\nElementos negativos\n");
            foreach (int item in pilaOrdenada)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }
            */
            List<int> listNum = new List<int>(20);

            for (int i = 0; i < 20; i++)
            {
                verif = rand.Next(-300, 300);
                while (verif == 0)
                {
                    verif = rand.Next(-100, 100);
                }
                listNum.Add(verif);
            }
            foreach (int item in listNum)
            {
                Console.WriteLine(item);
            }

            //ordeno
            Console.WriteLine("\nElementos ordenados\n");
            listNum.Sort();

            foreach (int item in listNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nElementos positivos\n");
            for (int i = 19; i > 0; i--)
            {
                if (listNum[i] > 0)
                {
                    Console.WriteLine(listNum[i]);
                }
            }
            Console.WriteLine("\nElementos negativos\n");
            foreach (int item in listNum)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }



            Console.ReadLine();

        }
    }
}
