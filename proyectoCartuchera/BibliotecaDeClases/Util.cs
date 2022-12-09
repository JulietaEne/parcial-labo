using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Util
    {
        protected float precio;
        protected string marca;

        //CONSTRUCTOR
        public Util()
        {
        }

        public Util(float precio, string marca)
        {
            this.precio = precio;
            this.marca = marca;
        }
        
        //PROPIEDADES
        public float Precio
        {
            get { return precio; }
            set { precio = value; } //validar con una exception!
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public virtual string Titulo()
        {
            string titulo = "Crear útil";
            return titulo;
        }

        //METODOS
        public static List<Util> operator +(List<Util> lista, Util objeto)
        {
            lista.Add(objeto);
            return lista;
        }
    }
}