using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;
            int cantDias = 0;
            DateTime fechaActual = DateTime.Now;
            int i;
            bool nacBisciesto = false;
            int cantBis = 0;
            int cantNoBis = 0;

            Console.WriteLine("Ingrese su fecha de nacimiento");
            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            anio = int.Parse(Console.ReadLine());

            switch(mes)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    //30 dias
                    cantDias += (30 - dia);
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    //31 dias
                    cantDias += (31 - dia);
                    break;
                case 2:
                    //28 o 29 dias
                    if ((anio % 4) == 0) // calcula si el año de nacimiento es bisiesto
                    {
                        if ((anio % 100) == 0)
                        {
                            if ((anio % 400) == 0)
                            {
                                cantDias += (29 - dia);
                                nacBisciesto = true;
                            }
                            else
                                cantDias += (28 - dia);
                        }
                        else
                        {
                            cantDias += (29 - dia);
                            nacBisciesto = true;
                        }
                    }
                    else
                        cantDias += (28 - dia);
                    break;
                default:
                    //no existe
                    break;
            }
            for(i = mes+1; i <= 12; i++) //enpieza a partir del siguiente mes del nacimiento
            { //contando los meses que quedan del año
                switch(i)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        cantDias += 30;
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        cantDias += 31;
                        break;
                    case 2:
                        if (nacBisciesto == true)
                            cantDias += 29;
                        else
                            cantDias += 28;
                        break;
                }
            }
            
            //calculo de la cantidad de años vividos
            for(i=anio+1; i<fechaActual.Year; i++)
            {
                if ((i % 4) == 0) // calcula si el año de nacimiento es bisiesto
                {
                    if ((i % 100) == 0)
                    {
                        if ((i % 400) == 0)
                            cantBis++;
                        else
                            cantNoBis++;
                    }
                    else
                        cantBis++;
                }
                else
                    cantNoBis++;
            }
            cantDias += (cantBis * 366);
            cantDias += (cantNoBis * 365);

            // calculo los dias del año actual
            for (i = 1; i < fechaActual.Month; i++) 
            { 
                switch (i)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        cantDias += 30;
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        cantDias += 31;
                        break;
                    case 2:
                        if ((fechaActual.Year % 4) == 0) // calcula si el año actual es bisiesto
                        {
                            if ((fechaActual.Year % 100) == 0)
                            {
                                if ((fechaActual.Year % 400) == 0)
                                    cantDias += 29;
                                else
                                    cantDias += 28;
                            }
                            else
                                cantDias += 29;
                        }
                        else
                            cantDias += 28;
                        break;
                }
            }

            cantDias += fechaActual.Day;
            Console.Write("Cantidad de dias vividos hasta el {0:dd/MM/yy}: ",fechaActual);
            Console.Write(cantDias);
            Console.Read();
        }
    }
}
