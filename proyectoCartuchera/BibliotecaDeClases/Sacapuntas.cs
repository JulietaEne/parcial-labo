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

        public Sacapuntas()
        {
        }

        public Sacapuntas(float precio, string marca, string material) : base(precio, marca)
        {
            this.material = material;
        }

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public override string Titulo()
        {
            return base.Titulo() + " Sacapuntas";
        }
    }
}
