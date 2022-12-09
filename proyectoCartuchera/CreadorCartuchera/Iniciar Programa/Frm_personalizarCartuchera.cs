using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreadorCartuchera.Iniciar_Programa
{
   
    public partial class Frm_personalizarCartuchera : Form
    {
        /*
         *  VALORES ORIGINALES SOLICITADOS
         *  
        Vconst int capacidadIndicada = 15;
        const float precioEventoIndicado = 500;*/


        Cartuchera<Util> miCartuchera; 
        //CONSTRUCTOR
        public Frm_personalizarCartuchera(Cartuchera<Util> unaCartuchera)
        {
            InitializeComponent();
            miCartuchera = unaCartuchera; 
            
        }
        
        //METODOS:

        //para setear valores
        private void Frm_personalizarCartuchera_Load(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void tbx_inputCapacidad_KeyPress(object sender, KeyPressEventArgs e) //para que acepte solo numeros
        {
            MetodosAux.RestringirAInputNumerico(e);
        }

        private void tbx_inputPrecio_KeyPress(object sender, KeyPressEventArgs e) //para que acepte int y float
        {
            MetodosAux.RestringirAInputAIntOFloat(sender, e);
        }

        //de comportamiento: 
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(AsignarPrecioACartuchera() && AsignarCapacidadACartuchera())
            {
                MetodosAux.AbrirFormAgregarUtiles(miCartuchera);
            }
            else
            {
                AvisoCamposSinCompletar();
            }
        }

        private void btn_noModificar_Click(object sender, EventArgs e)
        {
            SetearCartucheraOriginal();
            this.Close();
            MetodosAux.AbrirFormAgregarUtiles(miCartuchera);
        }


        //metodos aux
        private void IniciarFormulario()
        {
            tbx_inputCapacidad.Text = $"{miCartuchera.CapacidadCartuchera}";
            tbx_inputPrecio.Text = $"{miCartuchera.PrecioEvento}";
            lbl_mensaje.Visible = false;
            btn_noModificar.Visible = false;
        }

        private bool AsignarPrecioACartuchera()
        {
            if (!string.IsNullOrEmpty(tbx_inputPrecio.Text) && float.TryParse(tbx_inputPrecio.Text, out float inputPrecio))
            {
                miCartuchera.PrecioEvento = inputPrecio;
                return true;
            }
            return false;
        }

        private bool AsignarCapacidadACartuchera()
        {
            if (!string.IsNullOrEmpty(tbx_inputCapacidad.Text) && int.TryParse(tbx_inputCapacidad.Text, out int inputCapacidad))
            {
                miCartuchera.CapacidadCartuchera = inputCapacidad;
                return true;
            }
            return false;
        }



        

        private void AvisoCamposSinCompletar()
        {
            lbl_mensaje.Text = "Complete todos los campos para continuar";
            lbl_mensaje.Visible = true;
            btn_noModificar.Visible = true;
        }


        private void SetearCartucheraOriginal()
        {
            miCartuchera.PrecioEvento = 500;
            miCartuchera.CapacidadCartuchera = 15;
        }
        
    }
}
