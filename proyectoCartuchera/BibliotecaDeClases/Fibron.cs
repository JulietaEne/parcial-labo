using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq.Expressions;

namespace BibliotecaDeClases
{
    public class Fibron : Util
    {
        private string color;
        private int cantidadTinta;

        //CONSTRUCTOR
        public Fibron()
        {
        }
        public Fibron(float precio, string marca, string color, int cantidadTinta) : base(precio, marca)
        {
            this.color = color;
            this.cantidadTinta = cantidadTinta;
        }

        //PROPIEDADES
        public string Color
        {
            get { return color; }
        }

        public int CantidadTinta
        {
            get { return cantidadTinta; }
        }

        public override string Titulo()
        {
            return base.Titulo() + " Goma";
        }

        //METODOS
        public int Resaltar(int cantidad)
        {
            if (HayTinta(cantidad))
            {
                return cantidadTinta -= cantidad;
            }
            else
            {
                throw new Exception();//no me toma el SinTintaException :(
            }
        }

        public bool PudoResaltar()
        {
            Random random = new Random();
            int tintaAGastar = random.Next(0, 10);
            try
            {
                Resaltar(tintaAGastar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //METODOS AUX
        private bool HayTinta(int cantidad)
        {
            if (this.cantidadTinta >= cantidad)
            {
                return true;
            }
            return false;
        }

       
    }
}
