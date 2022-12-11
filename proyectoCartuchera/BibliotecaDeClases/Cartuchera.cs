using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BibliotecaDeClases
{
    public class Cartuchera<T> where T : Util
    {

        private int capacidadCartuchera;
        private List<T> listaUtiles = new List<T>();
        private float precioEvento;
        private List<Lapiz> listaLapices;
        //private string mensajeTicket;

        public event Func<float> eventoPrecio;


        //CONSTRUCTOR
        public Cartuchera(float precioTope, int capacidadCartuchera)
        {
            this.precioEvento = precioTope;
            this.capacidadCartuchera = capacidadCartuchera;
            this.listaUtiles = new List<T>();
        }

        //PROPIEDADES
        public int CapacidadCartuchera
        {
            get { return capacidadCartuchera; }
            set { capacidadCartuchera = value; } 
        }

        public List<T> ListaUtiles
        {
            get { return listaUtiles; }
        }

        public float PrecioTotalCartuchera
        {
            get { return CalcularPrecioTotal(); }
        }

        public float PrecioEvento
        {
            get { return precioEvento; }
            set { precioEvento = value; }
        }

        public int CantidadElementos
        {
            get { return listaUtiles.Count(); }
        }

        //METODOS


        public List<Util> MostrarListaUtiles()
        {
            List<Util> unaLista = new List<Util> ();
            foreach (Util unUtil in listaUtiles)
            {
                if (unUtil is Lapiz)
                {
                    unaLista.Add((Lapiz)unUtil);
                }
                else if(unUtil is Goma)
                {
                    unaLista.Add((Goma)unUtil);
                }
                else if(unUtil is Sacapuntas)
                {
                    unaLista.Add((Sacapuntas)unUtil);
                }
                else if(unUtil is Fibron)
                {
                    unaLista.Add((Fibron)unUtil);
                }
            }
            return unaLista;
        }

        public List<Lapiz> MostrarListaLapices()
        {
            listaLapices = new List<Lapiz>();

            foreach (Util unUtil in listaUtiles)
            {
                if(unUtil is Lapiz)
                {
                    listaLapices.Add((Lapiz)unUtil);
                }
            }
            return listaLapices;
        }

        
        /*public string MensajeTicket
        {
            get { return mensajeTicket; }
        }*/

        //METODOS
        public List<T> AddToCartuchera(Cartuchera<T> unaCartuchera, T objeto)
        {
            if (HayEspacio())
            {
                return unaCartuchera + objeto;
            }
            else
            {
                throw new Excepciones(); //en el form llamo al metodo cartucheraLlenaException
            }
        }

        public void SobrescribirUtil(Util utilModificado, int posicion)
        {
            listaUtiles[posicion] = (T)utilModificado;

           //return listaUtiles;
        }

        public void EliminarUtil(Util utilModificado, int posicion)
        {
            listaUtiles.Remove(listaUtiles[posicion]);
        }

        public List<Fibron> ListarFibrones()
        {
            List<Fibron> lista = new List<Fibron>();
            foreach (Util unUtil in listaUtiles)
            {
                if (unUtil is Fibron)
                {
                    lista.Add((Fibron)unUtil);
                }
            }
            return lista;
        }

        /*public List<T> listaTipoUtil(T tipo)
        {
            List<T> lista = new List<T> ();
            foreach(Util unUtil in listaUtiles)
            {
                if(unUtil is T)
                {
                    lista.Add((T)unUtil);
                }
            }
            return lista; 
        }*/

        public Fibron ElegirUnFibron()
        {
            List<Fibron> listaFibrones = new List<Fibron>();
            Random random = new Random();
            Fibron unFibron;
            int indexFibron = random.Next(1, 3);
            listaFibrones = ListarFibrones();

            unFibron = listaFibrones[indexFibron];
            return unFibron;
        }



        //METODOS AUXILIARES

        /*private bool rangoPrecio(floar unPrecio)
        {
            if(unPrecio > )
        }*/
        private bool HayEspacio()
        {
            if (this.capacidadCartuchera == this.listaUtiles.Count)
            {
                return false;
            }
            return true;
        }

        public static List<T> operator +(Cartuchera<T> unaCartuchera, T objeto)
        {
            unaCartuchera.listaUtiles.Add(objeto);
            return unaCartuchera.ListaUtiles;
        }

        private bool SuperaPrecioTope()
        {
            if (CalcularPrecioTotal() >= this.precioEvento)
            {
                return true;
            }
            return false;
        }

        private float CalcularPrecioTotal()
        {
            float precioTotal = 0;
            foreach (T unUtil in listaUtiles)
            {
                precioTotal += unUtil.Precio;
            }
            return precioTotal;
        }

        public Util BuscarUtilPorIndice(int indice)
        {
            return listaUtiles[indice];
        }

    }
}
