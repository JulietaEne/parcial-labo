using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using Newtonsoft.Json;
//using System.Text.Json.Serialization;
using ManejadorDeArchivos;
//using System.Xml.Serialization;

namespace CreadorCartuchera.Iniciar_Programa
{
    public partial class Frm_Inicio : Form
    {
        //ATRIBUTOS
        const int capacidadIndicada = 15;
        const float precioEventoIndicado = 500;

        Cartuchera<Util> unaCartuchera;
        int capacidad;
        float precioEvento;

       // static bool guardarArchivo;


        //CONSTRUCTOR
        public Frm_Inicio()
        {
            InitializeComponent();
            capacidad = capacidadIndicada;
            precioEvento = precioEventoIndicado;
           // guardarArchivo = false;
        }

       
        //METODOS
        private void Frm_Inicio_Load_1(object sender, EventArgs e)
        {
            IniciarPrograma();
        }

        private void btn_1_Click_1(object sender, EventArgs e)
        {
            CrearCartuchera();

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrarImoprtar_Click(object sender, EventArgs e)
        {
            MostrarSeccionImportar(true);
        }

        private void btn_importarJson_Click(object sender, EventArgs e)
        {
            Lapiz unUtil =  IDeserealiza<Lapiz>.LeerJson("ClaseLapiz");
            unaCartuchera = new Cartuchera<Util>(precioEventoIndicado, capacidadIndicada);
            unaCartuchera.AddToCartuchera(unaCartuchera, unUtil);
            dgv_cartucheraImportada.DataSource = unaCartuchera.ListaUtiles;


            /*string miJson = File.ReadAllText("Cartuchera3");
            Lapiz unLapiz = JsonSerializer.Deserialize<Lapiz>(miJson);*/


        }

        private void btn_importarXlm_Click(object sender, EventArgs e)
        {
            /*
             * IMPORTAR UN ONJETO anda ok 
             * 
             * 
             */
            Util unUtil = IDeserealiza<Util>.LeerXml("ClaseLapiz");
            unaCartuchera = new Cartuchera<Util>(precioEventoIndicado,capacidadIndicada);
            unaCartuchera.AddToCartuchera(unaCartuchera, unUtil);
            dgv_cartucheraImportada.DataSource = unaCartuchera.ListaUtiles;

            //dgv_cartucheraImportada.DataSource = listaUtiles;
            /*
             *  IMPORTAR UNA LISTA
             
             List<Util> listaUtiles = IDeserealiza<Util>.LeerListaXml("Cartuchera2");
             rtb_datos.Text = listaUtiles.ToString();
             dgv_cartucheraImportada.DataSource = listaUtiles;*/
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MetodosAux.AbrirFormAgregarUtiles(unaCartuchera, true);
        }

        //METODOS AUX
        private void IniciarPrograma()
        {
            lbl_titulo.Text = "Bienvenido al creador de Cartuchera";
            lbl_msjInicio.Text = "Desea crear una cartuchera?";
            btn_1.Text = "Crear cartuchera";
            btn_0.Text = "Salir";
            MostrarSeccionImportar(false);
        }

        private void MostrarSeccionImportar(bool visible)
        {
            gb_importar.Visible = visible;
            dgv_cartucheraImportada.Visible = visible;
            btn_modificar.Visible = visible;
            btn_cancelar.Visible = visible;
        }

        private void CrearCartuchera()
        {
            unaCartuchera = new Cartuchera<Util>(precioEvento, capacidad);
            string txtCapacidad = $"\nCapacidad: {unaCartuchera.CapacidadCartuchera}";
            string txtAvisoTicket = $"\nTicket por alerta de precio: ${unaCartuchera.PrecioEvento}";

            
            lbl_msjInicio.Text = "Se ha creado la cartuchera" + txtCapacidad + txtAvisoTicket;
            DialogResult r = MessageBox.Show("Desea modificar la capacidad y/o el alerta de precio?", "Modificar cartuchera", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                ModificarPreferenciasDeCartuchera();
               /* if (guardarArchivo == true)
                {
                    MostrarBotonesGuardarArchivo();
                }*/
            }
            else
            {
                MetodosAux.AbrirFormAgregarUtiles(unaCartuchera, false);
               /* if(guardarArchivo == true)
                {
                    MostrarBotonesGuardarArchivo();
                }*/
            }
        }

        private void ModificarPreferenciasDeCartuchera()
        {
            Frm_personalizarCartuchera formPersonalizar = new Frm_personalizarCartuchera(unaCartuchera);
            formPersonalizar.ShowDialog();
        }

        
    }
}
