using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    [Serializable]
    internal class Excepciones : Exception
    {
        public string CartucheraLlenaException()
        {
            return "cartuchera sobrecargada";
        }

        public string SinTintaException()
        {
            return "no hay suficiente tinta";
        }

    }
}
