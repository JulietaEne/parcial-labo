using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ManejadorDeArchivos
{
    public class ISerializa<T>
    {
        static string ruta;
        static ISerializa()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta += @"/Archivos-Serializacion";
        }

        public static string Ruta
        {
            get { return ruta; }
        }

        public static void EscribirXml(T datos, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            using (StreamWriter sw = new StreamWriter(rutaCompleta))//using-> hace la conección
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T)); //instancio el objeto serializador de xml
                xmlSerializer.Serialize(sw, datos);
            }
        }

        public static void EscribirListaXml(List<T> datos, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            using (StreamWriter sw = new StreamWriter(rutaCompleta, true))//using-> hace la conección
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T)); //instancio el objeto serializador de xml
                foreach(T item in datos)
                {
                    xmlSerializer.Serialize(sw, item);
                }
                
            }
        }

        public static bool ExisteArchivo(string nombreArchivo)
        {
            if (Directory.Exists(nombreArchivo))
            {
                return true;
            }
            return false;
        }

       

        public static void EscribirObjetoJson(T datos, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".json";
           
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            string objetoJson = JsonSerializer.Serialize(datos, options);

            File.WriteAllText(rutaCompleta, objetoJson);
        }

        public static void EscribirListaJson(List<T> datos, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".json";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            StringBuilder objetoJson = new StringBuilder();
            foreach (T item in datos)
            {
                 objetoJson.AppendLine( JsonSerializer.Serialize(item, options));
            }
            

            File.WriteAllText(rutaCompleta, objetoJson.ToString());
        }

        



    }
} 
