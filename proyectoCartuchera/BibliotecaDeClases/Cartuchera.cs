using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ManejadorDeArchivos; 

namespace BibliotecaDeClases
{
    public class Cartuchera<T> where T : Util
    {
        private int idCartuchera; //en base
        private int capacidadCartuchera; //en base
        private List<T> listaUtiles = new List<T>();
        private float precioEvento; //en base
        private List<Lapiz> listaLapices;
        private string nombre; //en base


        public event Func<float> eventoPrecio;


        //CONSTRUCTOR
        public Cartuchera()
        {
        }
        public Cartuchera(int idCartuchera, float precioTope, int capacidadCartuchera, string nombre) : this(precioTope, capacidadCartuchera, nombre)
        {
            this.idCartuchera = idCartuchera;
        }
        public Cartuchera(float precioTope, int capacidadCartuchera, string nombre) : this(precioTope, capacidadCartuchera)
        {
            this.nombre = nombre; 
        }
        public Cartuchera(float precioTope, int capacidadCartuchera) 
        {
            this.idCartuchera = LeerIdGuardado();
            this.precioEvento = precioTope;
            this.capacidadCartuchera = capacidadCartuchera;
            this.listaUtiles = new List<T>();
            this.nombre = "Sin nombre";
        }

        //PROPIEDADES
        public int IdCartuchera
        {
            get { return idCartuchera; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        public int CapacidadCartuchera
        {
            get { return capacidadCartuchera; }
            set { capacidadCartuchera = value; } 
        }
        public int CantidadElementosContenidos
        {
            get { return listaUtiles.Count(); }
        }

        public List<T> ListaUtiles
        {
            get { return listaUtiles; }
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


        private int LeerIdGuardado()
        {
            int id;
            int idNuevo; 
            try
            {
                id = ManejadorArchivos.LeerArchivoInt("idCartuchera");
            }
            catch (MyException excep)
            {
                id = excep.ArchivoIdCartucheraNoEncontrado();
            }
            idNuevo = id + 1; 
            ManejadorArchivos.SobreescribirArchivo(idNuevo, "idCartuchera"); //esto deberia suceder solo cuando guardo una cartu
            return id;
        }

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
