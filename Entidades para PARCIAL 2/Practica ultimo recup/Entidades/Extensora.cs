using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class Extensora
    {
        public static string MostrarBD(this Producto p)
        {
            string retValue = "";
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                SqlCommand consulta = new SqlCommand("SELECT * FROM productos", sql);
                SqlDataReader data = consulta.ExecuteReader();
                if (data != null)
                {
                    while (data.Read())
                    {
                        retValue += data["nombre"] + "-" + data["stock"] + "\n";
                    }
                }
                data.Close();
                sql.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            return retValue;
        }
    }
}
