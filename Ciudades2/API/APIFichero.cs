using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades2.API
{
    public static class APIFichero
    {
        // Recursos
        private const string DIRECTORIO = "Ciudades\\";
        private const string EXENSION = ".txt";

        // Crear Archivos
        public static void CrearDirectorio()
        {
            if (!Directory.Exists(DIRECTORIO))
            {
                Directory.CreateDirectory(DIRECTORIO);
            }
        }

        public static void CrearFichero(string nombre)
        {
            // Recursos

            StreamWriter escritor = null;

            // Validamos que no exista, si lo hace lanzará una excepción
            ValidarExistenciaFichero(nombre);

            escritor = File.CreateText(DIRECTORIO+nombre+EXENSION);

            escritor.Close();
        }

        public static void EscribirFichero(string nombre, string contenido)
        {
            // Recursos
            StreamWriter Escritor = null;
            string aux = "";

            // Validar Existencia
            ValidarExistenciaContenido(nombre, contenido);

            // Seleccionamos el fichero, sobrescribe
            Escritor = File.AppendText(DIRECTORIO+nombre+EXENSION);

            // Escribimos
            Escritor.WriteLine(contenido);

            Escritor.Close();
        }


        // Consultar

        public static string[] ConsultarDirectorio()
        {
            // Recursos

            string[] ListaProvincias;

            ListaProvincias = Directory.GetFiles(DIRECTORIO);
            string aux;

            // Limpiar Nombre

            for (int indice = 0; indice < ListaProvincias.Length; indice++)
            {
                aux = ListaProvincias[indice];

                aux = aux.Substring(aux.IndexOf("\\") + 1);
                aux = aux.Substring(0, aux.IndexOf("."));

                ListaProvincias[indice] = aux;
            }

            return ListaProvincias;
        }

        public static string[] ConsultarFichero(string nombre)
        {
            // Recursos
            string[] ContenidoFichero;

            ContenidoFichero = File.ReadAllLines(DIRECTORIO+nombre+EXENSION);


            return ContenidoFichero;

        }


        // Validación

        public static void ValidarExistenciaFichero(string nombre)
        {
            // Recursos

            string[] ListaFicheros = ConsultarDirectorio();
            string aux;

            nombre = nombre.Trim().ToLower();

            foreach(string cadena in ListaFicheros)
            {
                aux = cadena.Trim().ToLower();

                if (aux.Equals(nombre)) throw new Exception($"La ciudad {nombre} esta repetida");
            }
        }

        private static void ValidarExistenciaContenido(string nombre, string cont)
        {
            // Recursos
            string aux;

            foreach (string cadena in ConsultarFichero(nombre))
            {
                aux = cadena.ToLower().Trim();

                if (aux.Equals(cont)) throw new Exception("Ciudad repetida");
            }
        }

    }
}
