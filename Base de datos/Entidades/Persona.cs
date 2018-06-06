using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// para conectar con base de datos
using System.Data.SqlClient; //sql


namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _id;

        public string Nombre 
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int Edad 
        {
            get { return this._edad; }
            set 
            {
                if (value > 1 && value < 120)
                {
                    this._edad = value;     
                }
            } 
        }

        public int ID 
        {
            get { return this._id; } 
        }

        public Persona(string nom, string ap, int edad)
        {
            this._nombre = nom;
            this._apellido = ap;
            this._edad = edad;
        }

        public Persona(int id, string nom, string ap, int edad)
            : this(nom, ap, edad)
        {//verificar id
            this._id = id;
        }

        public static List<Persona> TraerTodos()
        {
            Persona nuevaPersona;
            List<Persona> listadoP = new List<Persona>();
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);//conexion es el setteo que cree en -> propiedades del proyecto -> settings
                sql.Open();
                SqlCommand consulta = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas", sql);
                SqlDataReader data = consulta.ExecuteReader();//el dataReader puede tener un registro, muchos o ninguno
                while (data.Read()) //dataRead es de solo lectura, una vez que lo leo se elimina cada registro leido. No puedo hacer busquedas
                {
                    nuevaPersona = new Persona(int.Parse(data[0].ToString()), data["nombre"].ToString(), data["apellido"].ToString(), int.Parse(data["edad"].ToString()));
                    listadoP.Add(nuevaPersona);
                    // el 0 es el id, el 1 nombre.... devuelve un object -> debo castearlo
                }
                data.Close();
                sql.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            return listadoP;
        }
    }
}
