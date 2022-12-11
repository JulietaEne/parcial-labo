using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace BibliotecaDeClases
{
    internal class IDeserealiza<T>
    {
        static string ruta;

        static IDeserealiza()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta += @"/Archivos-Serializacion";
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
            datos = JsonSerializer.Deserialize<T>(archivoJson, options);

            return datos;

        }

    }
}
