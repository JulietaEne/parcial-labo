using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    [XmlInclude(typeof(Lapiz))]
    [XmlInclude(typeof(Goma))]
    [XmlInclude(typeof(Sacapuntas))]
    [XmlInclude(typeof(Fibron))]
    public abstract class Util
    {
        protected eUtiles tipoUtil;
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
            set { 
                    if(value > 0) 
                    precio = value;
                }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public eUtiles TipoUtil
        {
            get { return tipoUtil; }
            set { tipoUtil = value; }
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