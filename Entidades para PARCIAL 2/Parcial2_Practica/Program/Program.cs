﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Program
{
    public delegate string ListadoBD(ISerializable obj);

    class Program
    {
        static void Main(string[] args)
        {
            Cajon<Fruta> cajon = new Cajon<Fruta>(3, 15.36f);
            Cajon<Platano> cajonplatanos = new Cajon<Platano>(4, 13.5f);
            Manzana m1 = new Manzana(15.0f, ConsoleColor.Red, "Moño Azul");
            Manzana m2 = new Manzana(22.06f, ConsoleColor.Magenta, "Parajes pampeanos");
            Manzana m3 = new Manzana(5.5f, ConsoleColor.DarkYellow, "El abuelo");
            Platano p1 = new Platano(4.8f, ConsoleColor.Yellow, "Ecuador");
            Platano p2 = new Platano(21.7f, ConsoleColor.DarkYellow, "Colombia");
            Platano p3 = new Platano(16.99f, ConsoleColor.Yellow, "Brasil");

            try
            {
                cajon += m1;
                cajon += m2;
                cajon += p1;
                cajon += p2;
                cajon += m3;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.WriteLine(cajon);
            //EVENTOS
            Console.WriteLine(cajon.PrecioTotal);

            try
            {
                cajonplatanos += p1;
                cajonplatanos += p2;
                cajonplatanos += p3;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
            }

            //SERIALIZAR CAJON        
            cajon.RutaArchivo = "cajon.xml";

            if (Program.Serializar(cajon))
                Console.WriteLine("Serializado correctamente.");
            else
                Console.WriteLine("Error al serializar.");

            //SERIALIZAR MANZANA            
            m2.RutaArchivo = "manzana.xml";

            if (Program.Serializar(m2))
            {
                Console.WriteLine("Manzana serializada correctamente.");
            }
            else
            {
                Console.WriteLine("Error al serializar Manzana.");
            }

            //DESERIALIZAR CAJON
            if (Program.Deserializar(cajon))
                Console.WriteLine(" > Cajon deserializado correctamente.");
            else
                Console.WriteLine(" > Error al deserializar Cajon.");

            //DESERIALIZAR MANZANA
            if (Program.Deserializar(m2))
                Console.WriteLine(" > manzana deserializada correctamente.");
            else
                Console.WriteLine(" > Error al deserializar manzana.");

            //BASE DE DATOS
            ListadoBD dele = new ListadoBD(Program.ObtenerPreciosBD);

            Console.WriteLine(dele.Invoke(cajon));

            Console.ReadLine();


        }

        private static bool Deserializar(ISerializable obj)
        {
            return obj.DeserializarXML();
        }

        private static string ObtenerPreciosBD(ISerializable obj)
        {
            string retValue = "PRECIOS BD\n";
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
            sql.Open();
            SqlCommand consulta;
            if (obj is Manzana)
            {
                consulta = new SqlCommand("SELECT precio FROM PreciosFruta WHERE descripcion = 'Manzana'", sql);
            }
            else
            {
                consulta = new SqlCommand("SELECT precio FROM PreciosFruta", sql);
            }
            SqlDataReader data = consulta.ExecuteReader();
            if (data != null)
            {
                while (data.Read())
                {
                    retValue += data["precio"].ToString();
                    retValue += "\n";
                }
            }
            data.Close();
            sql.Close();
            return retValue;
        }

        //private static string ObtenerPreciosBD(ISerializable obj)
        //{
        //    SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.Conexion);
        //    SqlCommand sqlcomm;

        //    sqlcon.Open();

        //    sqlcomm = new SqlCommand();
        //    sqlcomm.Connection = sqlcon;
        //    sqlcomm.CommandType = System.Data.CommandType.Text;
        //    sqlcomm.CommandText = "SELECT * FROM PreciosFruta";

        //    SqlDataReader lector = sqlcomm.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Console.WriteLine(lector.ToString() + "\n");
        //    }

        //    lector.Close();
        //    sqlcon.Close();

        //    return lector.ToString();
        //}


        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
    }
}
