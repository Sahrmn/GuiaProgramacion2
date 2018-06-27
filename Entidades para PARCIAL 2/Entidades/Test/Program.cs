using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string contenido = "Prueba de archivo...";
            //AdministradorDeArchivos<string>.Escribir("prueba.txt", contenido, false);
            //string salida = "";
            //AdministradorDeArchivos<string>.Leer("prueba.txt", out salida);
            //try
            //{
            //    IndexOutOfRangeException e = new IndexOutOfRangeException();
            //    throw e;
            //}
            //catch(Exception e)
            //{
            //    AdministradorDeArchivos<string>.LogErrores(e);
            //}
            //Console.WriteLine(salida);
            //Persona unaPersona = new Persona("Natalia", "Ramirez", 28);
            //AdministradorDeArchivos<string>.SerializarXML("SerializadoEnXML.xml", unaPersona);
            //Persona otraPersona = AdministradorDeArchivos<string>.DeserializarXML("SerializadoEnXML.xml");
            //Console.WriteLine(otraPersona.ToString());
            //AdministradorDeArchivos<string>.SerializarBinario("SerializadoEnBinario.bin", otraPersona);
            List<Persona> lista = new List<Persona>();
            Persona otraPersonaMas = AdministradorDeArchivos<string>.DeserializarBinario("SerializadoEnBinario.bin");
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Marcelo", "Navarro", 29);
            lista.Add(persona1);
            lista.Add(persona2);
            lista.Add(otraPersonaMas);
            AdministradorDeArchivos<Persona>.SerializarXML_Muchos("MuchosEnXML.xml", lista);
            //Console.WriteLine(otraPersonaMas.ToString());
            Console.Read();
        }
    }
}
