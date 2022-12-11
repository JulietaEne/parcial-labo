using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    [Serializable]
    public class Excepciones : Exception
    {
        public string CartucheraLlenaException(int limiteCapacidad)
        {
            return $"Cartuchera llena. Se ha alcanzado el límite de capacidad de {limiteCapacidad} indicado en la cartuchera";
        }

        public string SinTintaException()
        {
            return "no hay suficiente tinta";
        }

        public string RutaArchivo(string ruta)
        {
            return $"";
        }

    }
}
