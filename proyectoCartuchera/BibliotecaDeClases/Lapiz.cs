using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Lapiz : Util
    {
        private string color;

        public Lapiz ()
        {
        }

        public Lapiz(float precio, string marca, string color) : base(precio, marca)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string Titulo()
        {
            return base.Titulo() + " Lápiz";
        }
    }

}
