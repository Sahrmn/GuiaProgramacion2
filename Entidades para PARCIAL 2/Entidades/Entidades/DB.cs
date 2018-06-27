using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class DB
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        static DB()
        {
            _conexion = new SqlConnection();
            _comando = new SqlCommand();
            _comando.CommandType = CommandType.Text;//tipo de comando
            _comando.Connection = _conexion;//hago conexion
        }

        /// <summary>
        /// Inserta en una base de datos
        /// </summary>
        /// <param name="stringConexion">Conexion usada para abrir la base de datos(propiedades.default...)</param>
        /// <param name="sql">Consulta realizada</param>
        /// <returns></returns>
        public static bool InsertarEnDB(string stringConexion, string sql)
        {
            bool retValue = false;
            //"INSERT INTO Personas (nombre, apellido, edad) VALUES('Roberto', 'Romero', 36)";
            _conexion.ConnectionString = stringConexion;
            try
            {
                _comando.CommandText = sql;
                _conexion.Open();
                int data = _comando.ExecuteNonQuery();
                if (data == 1)
                {
                    retValue = true;
                }
                _conexion.Close();
            }
            catch (Exception e)
            {
                retValue = false;
                throw e;
            }
            finally
            {
                _conexion.Close();
            }
            return retValue;
        }


        /// <summary>
        /// Realiza una consulta y muestra el contenido de una fila con la id especificada
        /// </summary>
        /// <param name="stringConexion">Conexion usada para abrir la base de datos(propiedades.default...)</param>
        /// <param name="id">Id utulizada para realizar la busqueda en la base de datos</param>
        /// <param name="sql">Consulta</param>
        /// <returns></returns>
        public static Persona MostrarBD(string stringConexion, int id, string sql)
        {
            //SELECT * FROM Personas
            Persona per = null;
            try
            {
                _conexion.ConnectionString = stringConexion;
                _conexion.Open();
                _comando.CommandText = sql;
                SqlDataReader data = _comando.ExecuteReader();
                if (data != null)
                {
                    while (data.Read())
                    {
                        per = new Persona(data["nombre"].ToString(), data["apellido"].ToString(), int.Parse(data["edad"].ToString()));
                    }

                }
                _conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return per;
        }

        public static bool EliminarDeDB(string stringConexion, string sql)
        {
            bool retValue = false;
            try
            {
                _conexion.ConnectionString = stringConexion;
                //"DELETE FROM Personas WHERE id = 3";
                _conexion.Open();
                _comando.CommandText = sql;
                int data = _comando.ExecuteNonQuery();
                if (data == 1)
                {
                    retValue = true;
                }
                _conexion.Close();
            }
            catch
            {
                retValue = false;
                _conexion.Close();
            }
            return retValue;
        }

        
        /// <summary>
        /// Devuelve un datatable con toda la informacion de una base de datos
        /// </summary>
        /// <param name="stringConexion"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetData(string stringConexion, string sql)
        {
            DataTable tabla = null;
            try
            {
                _conexion.ConnectionString = stringConexion;
                _conexion.Open();
                _comando.CommandText = sql;
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = _comando;
                tabla = new DataTable();
                //tabla.Locale = System.Globalization.CultureInfo.CurrentCulture;
                data.Fill(tabla);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conexion.Close();
            }
            return tabla;
        }
    }
}
