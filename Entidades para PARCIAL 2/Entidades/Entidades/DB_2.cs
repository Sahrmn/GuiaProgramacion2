using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class DB_2
    {
        public bool SeleccionarEnBD()
        {
            bool retValue = true;
            Persona nuevaPersona;
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                SqlCommand consulta = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas WHERE id = 1", sql);
                SqlDataReader data = consulta.ExecuteReader();
                while (data.Read()) 
                {
                    nuevaPersona = new Persona(int.Parse(data[0].ToString()), data["nombre"].ToString(), data["apellido"].ToString(), int.Parse(data["edad"].ToString()));
                }
                data.Close();
                sql.Close();
            }
            catch
            {
                retValue = false;
                Console.WriteLine("Ocurrio un error");
            }
            return retValue;
        }

        public bool AgregarABD()
        {
            bool retValue = false;
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                //SqlCommand consulta = new SqlCommand("INSERT into Personas (nombre, apellido, edad) VALUES('" + this._nombre + "','" + this._apellido + "'," + this._edad + ")", sql);
                SqlCommand consulta = new SqlCommand("INSERT into Personas (nombre, apellido, edad) VALUES('pedrito', 'romero', 26)", sql);
                int data = consulta.ExecuteNonQuery();
                if (data == 1)
                    retValue = true;
                sql.Close();
            }
            catch
            {
                Console.WriteLine("Ocurrio un error agregando datos a la Base de Datos");
            }
            return retValue;
        }

        public static bool Borrar(/*Persona p*/)
        {
            bool retValue = false;
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                //SqlCommand consulta = new SqlCommand("DELETE from Personas WHERE id = "+ p._id,sql);
                SqlCommand consulta = new SqlCommand("DELETE from Personas WHERE id = 12", sql);
                int data = consulta.ExecuteNonQuery();
                if (data == 1)
                {
                    retValue = true;
                }
                sql.Close();
            }
            catch
            {
                Console.WriteLine("Error eliminando!");
            }
            return retValue;
        }

        public bool ModificarEnBD()
        {
            bool retValue = false;
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                SqlCommand consulta = new SqlCommand("UPDATE Personas SET apellido = 'Cruz', nombre = 'Ramiro', edad = 18 WHERE id = 6", sql);
                int data = consulta.ExecuteNonQuery();
                if (data == 1)
                    retValue = true;
                sql.Close();
            }
            catch
            {
                Console.WriteLine("Ocurrio un error al modificar");
            }
            return retValue;
        }

    }
}
