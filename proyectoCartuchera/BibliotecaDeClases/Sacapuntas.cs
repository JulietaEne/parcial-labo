using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Sacapuntas : Util
    {
        private string material;

        public Sacapuntas(float precio, string marca, string material) : base(precio, marca)
        {
            this.material = material;
        }

        public override string Titulo()
        {
            return base.Titulo() + " Sacapuntas";
        }
    }
}
