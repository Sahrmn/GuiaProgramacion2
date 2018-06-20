using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Entidades.Alumnos
{
    /* METODOS DE EXTENSION
     * los metodos de extension usan clases estaticas y publicas
     */
    public static class Extensora
    {
        /*metodo de instancia estatico - tiene cero parametros (no le paso nada)*/
        public static string ObtenerInfo(this Persona p)//el metodo se va a vincular a una instancia del tipo pasado (persona)
        {
            return p.Apellido + "-" + p.Nombre + "-" + p.Edad + "-" + p.Sexo; 
        }

        public static string ObtenerInfoDll(this Entidades.Externa.PersonaExterna p)
        {
            return p.ToString();
        }

        // escribir archivo la info de persona, pasar pad, ademas horas, minutos y segundos
        public static bool EscribirEnArchivo(this Entidades.Externa.PersonaExterna p, string path)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter(path);
                escribe.WriteLine(p.ObtenerInfoDll());
                escribe.WriteLine(DateTime.Now);
                escribe.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool EsNulo(this Object obj)
        {
            bool retValue = false;
            if (obj == null)
            {
                retValue = true;
            }
            return retValue;
        }

        public static int CantidadCaracteres(this string s)
        {
            return s.Count();
        }

        public static bool AgregarEnBaseDeDatos(this Persona p)
        {
            bool retValue = false;
            try
            {
                /* conexion es el setteo que cree en -> propiedades del proyecto -> settings
                 * name = conexion, type = Connection string , Value = tocar los ... ->
                 * sql server , y en server name = LAB5PC09\SQLEXPRESS o el nombre de la pc
                 * seleccionar base de datos!!!!!
                */
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                SqlCommand consulta = new SqlCommand("INSERT into Personas (apellido, nombre, sexo) VALUES('" + p.Apellido + "','" + p.Nombre + "'," + (int)p.Sexo + ")", sql);
                int data = consulta.ExecuteNonQuery();
                if (data == 1)
                {
                    retValue = true;
                }
                sql.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static Persona MostrarBD(this Persona p, int id)
        {
            Persona pers = null;
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                SqlCommand consulta = new SqlCommand("SELECT * from Personas WHERE id =" + id, sql);
                SqlDataReader data = consulta.ExecuteReader();
                if (data != null)
                {
                    while (data.Read())
                    {
                        pers = new Persona(data["nombre"].ToString(), data["apellido"].ToString(), int.Parse(data["nombre"].ToString()), ((Externa.ESexo)data["sexo"]));
                    }
                }
                sql.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pers;
        }

    }
}
