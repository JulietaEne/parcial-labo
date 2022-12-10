using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Goma : Util
    {
        private string tipo;

        public Goma()
        { }
        public Goma(float precio, string marca, string tipo) : base(precio, marca)
        {
            this.tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public override string Titulo()
        {
            return base.Titulo() + " Goma";
        }
    }
}
