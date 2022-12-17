using BibliotecaDeClases;
using CreadorCartuchera.Archivos;
using CreadorCartuchera.Iniciar_Programa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorDeArchivos; 

namespace CreadorCartuchera
{
    public partial class Frm_agregarUtiles : Form
    {
        Cartuchera<Util> miCartuchera;
        Util unUtil;
        int utilSeleccionado;
        bool eventoPrecio;
        bool cartucheraCargada;

        //List<Util> listaPrueba = new List<Util>();

        //CONSTRUCTOR
        public Frm_agregarUtiles(Cartuchera<Util> miCartuchera, bool cartucheraCargada)
        {
            InitializeComponent();
            this.miCartuchera = miCartuchera;
            eventoPrecio = false;
            this.cartucheraCargada = cartucheraCargada;
            this.Text = $"Cartuchera {miCartuchera.Nombre} / Agregar útiles";
        }

        //METODOS
        private void Frm_agregarUtiles_Load(object sender, EventArgs e)
        {
            IniciarForm();
            if(cartucheraCargada==true)
            {
                IniciarFormCartucheraCargada();
            }
            
            //Size = new Size(415; 668);
        }

        private void cmb_utiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_seleccionar.Visible = true;
            MostrarSeccionSetearUtil(false);
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            eUtiles utilSeleccionado = (eUtiles)cmb_utiles.SelectedIndex;
            //eUtiles utilSeleccionado = (eUtiles)cmbIndice;


            MostrarPropiedadesSegunUtil(utilSeleccionado, true);

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
            if(string.IsNullOrEmpty(txb_inputPrecio.Text) || (unUtil is Fibron && string.IsNullOrEmpty(txb_inputPropiety.Text)))
            {
                MensajeErrorAgregarUtil(true);
            }
            else
            {
                MensajeErrorAgregarUtil(false);
                SetearValoresIngresadosEnUtil();
                IntentarAgregarUtilACartuchera();
                EventoPrecio();


                MostrarSeccionDGView(true);
            }
            btn_guardarCartuchera.Visible = true;
        }

        


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MostrarSeccionSetearUtil(false);
            MostrarSeccionModificarUtil(false);
            //unUtil = null; 
        }

        private void dgv_utilesMiCartuchera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            utilSeleccionado = dgv_utilesMiCartuchera.CurrentRow.Index;
            MostrarBotonesDGV(true);
            MostrarSeccionSetearUtil(false);
            //logica de elegir un elemento >> lbl_detalleSeleccionado.Text = $"....";
            if(utilSeleccionado > -1)
            {
                lbl_detalleSeleccionado.Text = MensajeUtilSeleccionado(utilSeleccionado);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MostrarSeccionModificarUtil(true);
            
            //MostrarPropiedadesSegunUtil(unUtil.TipoUtil, true);
        }

        private void btn_aceptarModificarUtil_Click(object sender, EventArgs e)
        {
            //tengo que agarrar el util a modificar y setearle las nuevas cosas. no pasa nada si hay un campo sin info, en ese caso no se setea nada
            if (string.IsNullOrEmpty(txb_inputPrecio.Text) || (unUtil is Fibron && string.IsNullOrEmpty(txb_inputPropiety.Text)))
            {
                MensajeErrorAgregarUtil(true);
            }
            else
            {
                MensajeErrorAgregarUtil(false);
                SetearValoresIngresadosEnUtil();
                miCartuchera.SobrescribirUtil(unUtil, utilSeleccionado);
                MostrarSeccionModificarUtil(false);
                MostrarSeccionDGView(true);
                MostrarBotonesDGV(false);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Está a pinto de eliminar un útil de la cartuchera: {MensajeUtilSeleccionado(utilSeleccionado)}", "Confirmar eliminación", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                MostrarSeccionModificarUtil(false);
                miCartuchera.EliminarUtil(unUtil, utilSeleccionado);
                MostrarSeccionDGView(true);
                MostrarBotonesDGV(false);
            }
            
        }

        private void btn_guardarCartuchera_Click(object sender, EventArgs e)
        {
            if (miCartuchera.CantidadElementosContenidos < 1)
            {
                DialogResult result = MessageBox.Show("Se guardará una cartuchera vacía", "Cartuchera vacía", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                GuardarCartuchera(result);
            }
            else
            {
                DialogResult result = MessageBox.Show("Se guardará la cartuchera con útiles. Está seguro que desea salir de la carga de útiles?", "Cartuchera vacía", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                GuardarCartuchera(result);
            }
        }

        private void btn_leerTicket_Click(object sender, EventArgs e)
        {
            Frm_leerTicket formTicket = new Frm_leerTicket();
            formTicket.Show();
        }

        private void GuardarCartuchera(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                MostrarBotonesGuardarArchivo();
               // Frm_Inicio.GuardarArchivo = true;
               // this.Close();
            }
        }

        //METODOS AUX
        private void IniciarForm()
        {
            cmb_utiles.DataSource = Enum.GetNames(typeof(eUtiles));
            btn_seleccionar.Visible = false;
            MostrarSeccionSetearUtil(false);
            MostrarSeccionDGView(false);
            cmb_marca.DataSource = Enum.GetNames(typeof(eMarcasLibreria));
            MostrarBotonesDGV(false);
            lbl_msjError.Visible = false;
            btn_aceptarModificarUtil.Visible = false; 
            btn_guardarCartuchera.Visible = false;
            MostrarSeccionTicket(false);
        }

        private void IniciarFormCartucheraCargada()
        {
            IniciarForm();
            MostrarBotonesDGV(true);
            dgv_utilesMiCartuchera.DataSource = miCartuchera.ListaUtiles;
            dgv_utilesMiCartuchera.Visible = true;
            lbl_detalleSeleccionado.Visible = false;
        }

        private void MostrarSeccionSetearUtil(bool visibilidad)
        {
            gb_AgregarUtil.Visible = visibilidad;
            btn_agregar.Visible = visibilidad; 
            SeccionFibronVisible(false);
            
        }

        

        private void MostrarPropiedadesSegunUtil(eUtiles tipoUtil, bool visible)
        {
           
            MostrarSeccionSetearUtil(visible);
            switch(tipoUtil)
            {
                case eUtiles.Lápiz:
                    LapizPropieties();
                    break;

                case eUtiles.Goma:
                    GomaPropieties();
                    break;

                case eUtiles.Sacapuntas:
                    SacapuntasPropieties();
                    break;

                case eUtiles.Fibrón:
                    FibronPropieties();
                    break; 
            }
        }


        //Metodos aux

        
        private void LapizPropieties()
        {
            unUtil = new Lapiz();
            unUtil.TipoUtil = eUtiles.Lápiz;

            cmb_propiety2.DataSource = Enum.GetNames(typeof(eColor));
            lbl_inputPropiety2.Text = "Color:";
        }

        private void GomaPropieties()
        {
            unUtil = new Goma();
            unUtil.TipoUtil = eUtiles.Goma;

            lbl_inputPropiety2.Text = "Tipo goma:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eTipoGoma));
        }

        private void SacapuntasPropieties()
        {
            unUtil = new Sacapuntas();
            unUtil.TipoUtil = eUtiles.Sacapuntas;

            lbl_inputPropiety2.Text = "Material:";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eMaterial));
        }

        private void FibronPropieties()
        {
            unUtil = new Fibron();
            unUtil.TipoUtil = eUtiles.Fibrón;
            SeccionFibronVisible(true);
        }

        private void SeccionFibronVisible(bool visible)
        {
            lbl_inputPropiety.Visible = visible;
            txb_inputPropiety.Visible = visible;
            lbl_inputPropiety.Text = "Cant tinta:";
            txb_inputPropiety.PlaceholderText = "Ingrese numero entero";
            cmb_propiety2.DataSource = Enum.GetNames(typeof(eColor));
            lbl_inputPropiety2.Text = "Color:";
        }

        private void MostrarSeccionDGView(bool visible)
        {
            lbl_indicacionDgv.Text = $"Seleccione un útil de la cartuchera para eliminarlo o modificarlo";
            lbl_indicacionDgv.Visible = visible;
            dgv_utilesMiCartuchera.DataSource = null; //limpio el dgv
            dgv_utilesMiCartuchera.DataSource = miCartuchera.MostrarListaUtiles();//no anda
           
            dgv_utilesMiCartuchera.Visible = visible;

            //this.Size = new System.Drawing.Size(874; 668);
        }

        private void LimpiarCamposUtil()
        {
            txb_inputPrecio.Text = "";
            MostrarSeccionSetearUtil(false);
        }

        private void SetearValoresIngresadosEnUtil()
        {
            if (float.TryParse(txb_inputPrecio.Text, out float unPrecio))
            {
                unUtil.Precio = unPrecio;
            }
            unUtil.Marca = cmb_marca.Text;

            if (unUtil is Lapiz)
            {
                Lapiz unLapiz = (Lapiz)unUtil;
                unLapiz.Color = cmb_propiety2.Text;
            }
            else if (unUtil is Goma)
            {
                Goma unaGoma = (Goma)unUtil;
                unaGoma.Tipo = cmb_propiety2.Text;
            }
            else if (unUtil is Sacapuntas)
            {
                Sacapuntas unSacapuntas = (Sacapuntas)unUtil;
                unSacapuntas.Material = cmb_propiety2.Text;
            }
            else if (unUtil is Fibron)
            {
                Fibron unFibron = (Fibron)unUtil;
                unFibron.Color = cmb_propiety2.Text;
                if (int.TryParse(txb_inputPrecio.Text, out int cantTinta))
                {
                    unFibron.CantidadTinta = cantTinta;
                }
            }
        }

        private void MostrarBotonesDGV(bool visible)
        {
            lbl_detalleSeleccionado.Visible = visible;
            btn_modificar.Visible = visible;
            btn_eliminar.Visible = visible;
        }

        private string MensajeUtilSeleccionado(int indiceUtil)
        {
            StringBuilder sb = new StringBuilder();
            unUtil = miCartuchera.BuscarUtilPorIndice(indiceUtil); //ACÁ YA ME QUEDA SETEADO EL UTIL CON EL QUE ESTOY TRABAJANDO

            sb.AppendLine("Tipo de útil: " + unUtil.TipoUtil);
            sb.AppendLine("Marca: " + unUtil.Marca);
            sb.AppendLine("Precio: $" + unUtil.Precio.ToString());
            if (unUtil is Fibron)
            {
                Fibron unFibron = (Fibron)unUtil;
                sb.AppendLine("Cantidad de tinta: " + unFibron.CantidadTinta.ToString());
                sb.AppendLine("Color: " + unFibron.Color);

            }
            else if (unUtil is Lapiz)
            {
                Lapiz unLapiz = (Lapiz)unUtil;
                sb.AppendLine("Color: " + unLapiz.Color);
            }
            else if (unUtil is Goma)
            {
                Goma unaGoma = (Goma)unUtil;
                sb.AppendLine("Tipo de goma: " + unaGoma.Tipo);
            }
            else if (unUtil is Sacapuntas)
            {
                Sacapuntas unSacapuntas = (Sacapuntas)unUtil;
                sb.AppendLine("Material: " + unSacapuntas.Material);
            }

            return sb.ToString();
        }

        private void MensajeErrorAgregarUtil(bool visible)
        {
            lbl_msjError.Visible = visible;

            if (visible)
                lbl_msjError.Text = "Erorr para continuar \nComplete todos los campos";
            else
                lbl_msjError.Text = " ";
        }

        private void IntentarAgregarUtilACartuchera()
        {
            try//tengo que agregar el util a la lista
            {
                miCartuchera.AddToCartuchera(miCartuchera, unUtil);
                //listaPrueba.Add(unUtil);
                LimpiarCamposUtil();
            }
            catch (Excepciones excep)
            {
                MessageBox.Show(excep.CartucheraLlenaException(miCartuchera.CapacidadCartuchera));
            }
        }

        private void MostrarSeccionModificarUtil(bool visible)
        {
            //MostrarSeccionSetearUtil(visible);
            MostrarPropiedadesSegunUtil(unUtil.TipoUtil, visible);
            btn_aceptarModificarUtil.Visible = visible;

            btn_agregar.Visible = false;
        }

        private void EventoPrecio()
        {
            if (miCartuchera.PrecioTotalCartuchera >= miCartuchera.PrecioEvento)
            {
                // ManejadorArchivos.EscribirArchivo(unaCartuchera.MensajeTicket, "ticket");
                DateTime dateTime = DateTime.Now;
                ManejadorArchivos.EscribirArchivo($"{dateTime} - Se ha superado el monto máximo indicado para la cartuchera. Monto actual {miCartuchera.PrecioTotalCartuchera}", "ticket");
                MostrarSeccionTicket(true);
                if (eventoPrecio == false)
                {
                    MessageBox.Show($"Se ha superado el monto de ${miCartuchera.PrecioEvento}.\n Monto de la cartuchera: ${miCartuchera.PrecioTotalCartuchera}.\n Los tickets se generarán en: {ManejadorArchivos.Ruta} ");
                    eventoPrecio = true;
                }
            }
        }

        private void MostrarSeccionTicket(bool visible)
        {
            lbl_montoTotal.Text = $"Monto de la cartuchera: ${miCartuchera.PrecioTotalCartuchera}";
            lbl_montoTotal.Visible = visible;
            btn_leerTicket.Visible = visible;
        }

        private void MostrarBotonesGuardarArchivo()
        {
            Frm_guardarArchivo formGuardarArchivo = new Frm_guardarArchivo(miCartuchera);
            formGuardarArchivo.ShowDialog();
        }
    }
}
