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
    public class IDeserealiza<T>
    {
        static string ruta;

        static IDeserealiza()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"/Archivos-Deserializacion";
        }

        public static T LeerXml(string nombreArchivo)
        {
            //string archivo = string.Empty;
            T datos = default;
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".xml";
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    datos = (T)xmlSerializer.Deserialize(sr);
                }
            }
            return datos;
        }

        public static List<T> LeerListaXml(string nombreArchivo)//no anda
        {
            //string archivo = string.Empty;
            List<T> datos = default;
            T unDato = default; 
            string rutaCompleta = ruta + @"/" + nombreArchivo + ".xml";
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                   XmlSerializer xmlSerializer = new XmlSerializer(typeof(T)); //instancia un serializer del tipo T
                   
                }
            }
            return datos;
        }

        public static T LeerJson(string nombreArchivo)
        {
             T datos = default;
             string rutaCompleta = ruta + @"/" + nombreArchivo + ".json";
             if (!Directory.Exists(ruta))
             {
                 Directory.CreateDirectory(ruta);
             }

             JsonSerializerOptions options = new JsonSerializerOptions
             {
                 Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
             };

             string archivoJson = File.ReadAllText(rutaCompleta);
             datos = JsonSerializer.Deserialize<T>(archivoJson, options); //POR QUE NO ANDA

             return datos;

            //string miJson = File.ReadAllText(nombreArchivo);
        }

       

    }
}
