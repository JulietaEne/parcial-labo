using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeArchivos
{
    public static class ManejadorArchivos
    {
        static string ruta;

        static ManejadorArchivos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta += @"/ProyectoCartuchera";
        }

        public static string Ruta
        {
            get { return ruta; }
        }

        public static bool EscribirArchivo(string info, string nombreArchivo)//mensaje: lo que guardo // nombreArchivo: el nombre que le asigno
        {
            string rutaCompleta = ruta + $@"/{nombreArchivo}" + ".log";
            try
            {
                if (!Directory.Exists(ruta))//si la carpeta es inexistente
                {
                    Directory.CreateDirectory(ruta);//se la crea
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta, true))//using: para asegurar que la coneccion con el archivo se mantenga solo dentro del scope //StreamWriter: segundo paramtro true, permite appenear 
                {
                    sw.WriteLine(info);//escritura de archivo 
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
            return false;
        }

        public static string? BuscarArchivo(string ruta, string nombreArchivo)
        {
            string[] archivos = Directory.GetFiles(ruta);
            foreach (string archivo in archivos)
            {
                if (archivo.Contains(nombreArchivo))
                {
                    return archivo;
                }
            }
            return null;
        }

        public static string LeerArchivo(string archivo)
        {
            string rutaCompleta;
            string datos = string.Empty;

            if (Directory.Exists(ruta))
            {
                rutaCompleta = BuscarArchivo(ruta, archivo);
                datos = MostrarArchivo(rutaCompleta);
                /*if (rutaCompleta != null)
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        string line;
                        line = sr.ReadToEnd();
                        datos += line;
                    }
                }
                else
                {
                    throw new Exception();
                }*/
            }
            return datos;
        }

        public static string LeerArchivoIndicado(string rutaIngresada)
        {
            return MostrarArchivo(rutaIngresada); 
        }

        private static string MostrarArchivo(string rutaCompleta)
        {
            string datos = string.Empty;
            if (rutaCompleta != null)
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))//para leer
                {
                    string line;
                    line = sr.ReadToEnd();
                    datos += line;
                }
            }
            else
            {
                throw new Exception();
            }
            return datos; 
        }

    }
}
