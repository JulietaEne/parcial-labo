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

        static bool guardarArchivo;


        //CONSTRUCTOR
        public Frm_Inicio()
        {
            InitializeComponent();
            capacidad = capacidadIndicada;
            precioEvento = precioEventoIndicado;
            guardarArchivo = false;
        }

        public static bool GuardarArchivo
        {
            set { guardarArchivo = value; }
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


        //METODOS AUX
        private void IniciarPrograma()
        {
            lbl_titulo.Text = "Bienvenido al creador de Cartuchera";
            lbl_msjInicio.Text = "Desea crear una cartuchera?";
            btn_1.Text = "Crear cartuchera";
            btn_0.Text = "Salir";

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
                if (guardarArchivo == true)
                {
                    MostrarBotonesGuardarArchivo();
                }
            }
            else
            {
                MetodosAux.AbrirFormAgregarUtiles(unaCartuchera);
                if(guardarArchivo == true)
                {
                    MostrarBotonesGuardarArchivo();
                }
            }
        }

        private void ModificarPreferenciasDeCartuchera()
        {
            Frm_personalizarCartuchera formPersonalizar = new Frm_personalizarCartuchera(unaCartuchera);
            formPersonalizar.ShowDialog();
        }

        private void MostrarBotonesGuardarArchivo()
        {
            MessageBox.Show("Acá van los botones!");
        }

    }
}
