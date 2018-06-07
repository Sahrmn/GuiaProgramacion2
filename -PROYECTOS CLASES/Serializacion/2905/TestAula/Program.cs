using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Serialization;

namespace TestAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor unProfesor = new Profesor("Eduardo", "Reyes", 414545, "Profesor");
            Alumno alumno1 = new Alumno("Roberto", "Perez", 45454545, 121212);
            Alumno alumno2 = new Alumno("Maria", "Gonzalez", 65656, 23232);
            Alumno alumno3 = new Alumno("Maira", "Moreno", 02022, 787878);

            Aula aulaNueva = new Aula(5);
            aulaNueva._lista.Add(alumno1);
            aulaNueva._lista.Add(alumno2);
            aulaNueva._lista.Add(alumno3);

            //Console.WriteLine(aulaNueva.ToString());
            //if (GuardarXML("Alumnos.xml", alumno1))
            //    Console.WriteLine("Alumno agregado");
            //else
            //    Console.WriteLine("No se agrego el alumno");

            //if (Entidades.XML<Alumno>.GuardarXML("Alumnos.xml", alumno2))
            //    Console.WriteLine("Alumno agregado");
            //else
            //    Console.WriteLine("No se agrego el alumno");

            //Alumno alumno5;
            //if (Entidades.XML<Alumno>.LeerXML("Alumnos.xml", out alumno5))
            //    Console.WriteLine(alumno5.ToString());
            //else
            //    Console.WriteLine("No se pudo");

            //PROBAR SERIALIZAR LISTA
            Console.ReadLine();
            
        }


        //public static bool GuardarXML(string path, Alumno a)
        //{
        //    bool retValue = true;
        //    try
        //    {
        //        XmlTextWriter escribir = new XmlTextWriter(path, Encoding.UTF8);
        //        XmlSerializer seri = new XmlSerializer(typeof(Alumno));
        //        seri.Serialize(escribir, a);
        //        escribir.Close();
        //        retValue = true;
        //    }
        //    catch
        //    {
        //        retValue = false;
        //    }
        //    return retValue;
        //}

        //public static bool LeerXML(string path, out Alumno a)
        //{
        //    bool retValue = false;
        //    Alumno al = null;
        //    a = null;
        //    try
        //    {
        //        XmlTextReader leer = new XmlTextReader(path);
        //        XmlSerializer seri = new XmlSerializer(typeof(Alumno));
        //        al = (Alumno)seri.Deserialize(leer);
        //        leer.Close();
        //        retValue = true;
        //        if (al != null)
        //            a = al;
        //    }
        //    catch
        //    {
        //        retValue = false;
        //    }
        //    return retValue;
        //}
    }

    
}
