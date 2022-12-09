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

namespace CreadorCartuchera
{
    public partial class Frm_agregarUtiles : Form
    {
        Cartuchera<Util> miCartuchera;
        Util utilCreado; 

        //CONSTRUCTOR
        public Frm_agregarUtiles(Cartuchera<Util> miCartuchera)
        {
            InitializeComponent();
            this.miCartuchera = miCartuchera;
        }

        //METODOS
        private void Frm_agregarUtiles_Load(object sender, EventArgs e)
        {
            IniciarForm();
        }

        private void cmb_utiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            SeccionAgregarUtil(false);
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            int cmbIndice = cmb_utiles.SelectedIndex;
            //string utilSeleccionado = cmbIndice.ToString();


            MostrarPropiedadesSegunUtil(cmbIndice);

        }

        private void txb_inputPropiety_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosAux.RestringirAInputNumerico(e);
        }

        //METODOS AUX
        private void IniciarForm()
        {
            cmb_utiles.DataSource = Enum.GetNames(typeof(eUtiles));
            btn_seleccionar.Visible = false;
            SeccionAgregarUtil(false);
            cmb_marca.DataSource = Enum.GetNames(typeof(eMarcasLibreria));
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eColor));
            lbl_inputPropiety2.Text = "Color:";
        }

        private void SeccionAgregarUtil(bool visibilidad)
        {
            gb_AgregarUtil.Visible = visibilidad;
            SeccionFibronVisible(false);
        }

        

        private void MostrarPropiedadesSegunUtil(int indiceSeleccionado)
        {
            SeccionAgregarUtil(true);
            switch(indiceSeleccionado)
            {
                case 0:
                    LapizPropieties();
                    break;

                case 1:
                    GomaPropieties();
                    break;

                case 2:
                    SacapuntasPropieties();
                    break;

                case 3:
                    FibronPropieties();
                    break; 
            }
        }


        //class metodosAux
        private void LapizPropieties()
        {
            utilCreado = new Lapiz();
        }

        private void GomaPropieties()
        {
            utilCreado = new Goma();

            lbl_inputPropiety2.Text = "Tipo goma:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eTipoGoma));

        }

        private void SacapuntasPropieties()
        {
            utilCreado = new Sacapuntas();

            lbl_inputPropiety2.Text = "Material:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eMaterial));
        }

        private void FibronPropieties()
        {
            utilCreado = new Fibron();
            SeccionFibronVisible(true);
        }

        private void SeccionFibronVisible(bool visible)
        {
            lbl_inputPropiety.Visible = visible;
            txb_inputPropiety.Visible = visible;
            lbl_inputPropiety.Text = "Cant tinta:";
            txb_inputPropiety.PlaceholderText = "Ingrese numero entero";
        }

        
    }
}
