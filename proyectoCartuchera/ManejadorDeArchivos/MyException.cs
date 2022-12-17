using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeArchivos
{
    [Serializable]
    public class MyException : Exception
    {
        public int ArchivoIdCartucheraNoEncontrado()
        {
            ManejadorArchivos.SobreescribirArchivo(100,"idCartuchera");
            return ManejadorArchivos.LeerArchivoInt("idCartuchera");  
        }

        public string RutaInexistente()
        {
            return "ERROR. Ruta inexistente";
        }

    }
}
