using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;//xmlSerializer
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;//serializacion binaria

namespace Entidades
{
    public static class AdministradorDeArchivos<T>
    {
        /// <summary>
        /// Escribe un archivo. Devuelve true si pudo realizar correctamente la tarea
        /// </summary>
        /// <param name="path">Direccion del archivo mas nombre de archivo</param>
        /// <param name="contenido"></param>
        /// <param name="sobreescribir">false para sobreescribir, true para agregar al final</param>
        /// <returns></returns>
        public static bool Escribir(string path, string contenido, bool sobreescribir)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter(path, sobreescribir);
                //escribe.Write(contenido); escribe una cadena sin provocar salto de linea
                escribe.WriteLine(contenido);
                escribe.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool Leer(string path, out string contenido)
        {
            bool retValue = true;
            contenido = "";
            try
            {
                StreamReader leyendo = new StreamReader(path);
                //contenido = leyendo.ReadLine();  lee una linea
                //contenido = leyendo.Read(); lee una letra
                contenido = leyendo.ReadToEnd();
                leyendo.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        /// <summary>
        /// Escribe en un archivo de texto el dia, hora e informacion del error.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool LogErrores(Exception e)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter("logErrores.txt", true);
                string contenido = e.ToString();
                escribe.WriteLine("");
                escribe.WriteLine(DateTime.Now.ToString());
                escribe.WriteLine(contenido);
                escribe.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool SerializarXML(string archivo, Persona obj)
        {
            //using System.IO;
            //using System.Xml.Serialization;
            //using System.Xml;
            //recordar que tiene que ser un objeto con constructor por defecto
            //recordar que tengo que pasarle un archivo .xml
            //Si hay relacion de herencia debo colocar [XmlInclude(typeof(Clase))] en la clase base indicando cada clase heredada
            bool retValue = true;
            try
            {
                XmlTextWriter escribir = new XmlTextWriter(archivo, Encoding.UTF8); //si no toma el XmlTextWriter escribirlo igual, es tema de la ide...
                XmlSerializer ser = new XmlSerializer(typeof(Persona));//tipo que se desea serializar
                ser.Serialize(escribir, obj);
                escribir.Close();
            }
            catch(Exception e)
            {
                retValue = false;
                Console.WriteLine(e.Message);
            }
            return retValue;
        }

        public static bool SerializarXML_Muchos(string archivo, List<T> lo)
        {
            //using System.IO;
            //using System.Xml.Serialization;//xmlSerializer
            //using System.Xml;
            bool retValue = true;
            try
            {
                XmlTextWriter escribir = new XmlTextWriter(archivo, Encoding.UTF8); //si no toma el XmlTextWriter escribirlo igual, es tema de la ide...
                XmlSerializer ser = new XmlSerializer(typeof(List<T>));//tipo que se desea serializar
                ser.Serialize(escribir, lo);
                escribir.Close();
            }
            catch (Exception e)
            {
                retValue = false;
                Console.WriteLine(e.Message);
            }
            return retValue;
        }

        public static Persona DeserializarXML(string archivo)
        {
            Persona obj = null;
            try
            {
                XmlTextReader leer = new XmlTextReader(archivo); //si no toma el XmlTextWriter escribirlo igual, es tema de la ide...
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                obj =  (Persona)ser.Deserialize(leer); //reemplazo por el objeto a deserializar
                leer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return obj;
        }

        /// <summary>
        /// Serializa un objeto pasado por parametro a binario
        /// </summary>
        /// <param name="archivo">Nombre de archivo</param>
        /// <param name="obj">Objeto a serializar</param>
        /// <returns></returns>
        public static bool SerializarBinario(string archivo, Object obj)   
        {
            //using System.Runtime.Serialization.Formatters.Binary;
            //using System.IO;
            bool retValue = true;
            try
            {
                FileStream stream = new FileStream(archivo, FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(stream, obj);
                stream.Close();
            }
            catch(Exception e)
            {
                retValue = false;
                Console.WriteLine(e.Message);
            }
            return retValue;
        }

        public static Persona DeserializarBinario(string archivo)
        {
            //using System.Runtime.Serialization.Formatters.Binary;
            //using System.IO;
            //recordar marcar como serializable la clase que quiero serializar
            Persona obj = null;
            try
            {
                FileStream stream = new FileStream(archivo, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                obj = (Persona)ser.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return obj;
        }




    }
}
