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
        List<Util> listaPrueba = new List<Util>();

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
            //Size = new Size(415; 668);
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
        private void txb_inputPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosAux.RestringirAInputAIntOFloat(sender, e);
        }

        private void txb_inputPropiety_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosAux.RestringirAInputNumerico(e);
        }

        

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            SetearValoresIngresadosEnUtil();

            try//tengo que agregar el util a la lista
            {
                miCartuchera.AddToCartuchera(miCartuchera, utilCreado);
                //listaPrueba.Add(utilCreado);
                LimpiarCamposUtil();
            }
            catch (Excepciones)
            {
                Excepciones excep = new Excepciones();
                MessageBox.Show(excep.CartucheraLlenaException());
            }
            SeccionDGViewVisible(true);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            SeccionAgregarUtil(false);
        }

        //METODOS AUX
        private void IniciarForm()
        {
            cmb_utiles.DataSource = Enum.GetNames(typeof(eUtiles));
            btn_seleccionar.Visible = false;
            SeccionAgregarUtil(false);
            SeccionDGViewVisible(false);
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


        //Metodos aux

        
        private void LapizPropieties()
        {
            utilCreado = new Lapiz();
            utilCreado.TipoUtil = "Lápiz";
        }

        private void GomaPropieties()
        {
            utilCreado = new Goma();
            utilCreado.TipoUtil = "Goma";

            lbl_inputPropiety2.Text = "Tipo goma:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eTipoGoma));
        }

        private void SacapuntasPropieties()
        {
            utilCreado = new Sacapuntas();
            utilCreado.TipoUtil = "Sacapuntas";

            lbl_inputPropiety2.Text = "Material:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eMaterial));
        }

        private void FibronPropieties()
        {
            utilCreado = new Fibron();
            utilCreado.TipoUtil = "Fibrón";
            SeccionFibronVisible(true);
        }

        private void SeccionFibronVisible(bool visible)
        {
            lbl_inputPropiety.Visible = visible;
            txb_inputPropiety.Visible = visible;
            lbl_inputPropiety.Text = "Cant tinta:";
            txb_inputPropiety.PlaceholderText = "Ingrese numero entero";
        }

        private void SeccionDGViewVisible(bool visible)
        {
            lbl_nombreCartu.Text = $"Útiles de cartuchera";
            lbl_nombreCartu.Visible = visible;
            dgv_utilesMiCartuchera.DataSource = null; 
            dgv_utilesMiCartuchera.DataSource = miCartuchera.MostrarListaUtiles();//no anda
           
            dgv_utilesMiCartuchera.Visible = visible;

            //this.Size = new System.Drawing.Size(874; 668);
        }

        private void LimpiarCamposUtil()
        {
            txb_inputPrecio.Text = "";
            SeccionAgregarUtil(false);
        }

        private void SetearValoresIngresadosEnUtil()
        {
            if (float.TryParse(txb_inputPrecio.Text, out float unPrecio))
            {
                utilCreado.Precio = unPrecio;
            }
            utilCreado.Marca = cmb_marca.Text;

            if (utilCreado is Lapiz)
            {
                Lapiz unLapiz = (Lapiz)utilCreado;
                unLapiz.Color = cmb_propiety2.Text;
            }
            else if (utilCreado is Goma)
            {
                Goma unaGoma = (Goma)utilCreado;
                unaGoma.Tipo = cmb_propiety2.Text;
            }
            else if (utilCreado is Sacapuntas)
            {
                Sacapuntas unSacapuntas = (Sacapuntas)utilCreado;
                unSacapuntas.Material = cmb_propiety2.Text;
            }
            else if (utilCreado is Fibron)
            {
                Fibron unFibron = (Fibron)utilCreado;
                unFibron.Color = cmb_propiety2.Text;
                if (int.TryParse(txb_inputPrecio.Text, out int cantTinta))
                {
                    unFibron.CantidadTinta = cantTinta;
                }
            }
        }


    }
}
