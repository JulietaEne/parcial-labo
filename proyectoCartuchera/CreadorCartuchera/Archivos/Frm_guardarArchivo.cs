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
    public partial class Frm_guardarArchivo : Form
    {
        Cartuchera<Util> unaCartuchera;
        bool claseLapiz; 
        public Frm_guardarArchivo(Cartuchera<Util> unaCartuchera)
        {
            InitializeComponent();
            this.unaCartuchera = unaCartuchera;
            claseLapiz = true; 
        }
        private void Frm_guardarArchivo_Load(object sender, EventArgs e)
        {
            gb_tipoArchivo.Visible = false; 
        }
        private void gb_dato_Enter(object sender, EventArgs e)
        {
            if( rbtn_cartuchera.Checked)
            {
                claseLapiz = false; 
            }
            gb_tipoArchivo.Visible = true; 
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            string nombreArchivo = string.Empty; 
            bool serializar = NombreArchivo(nombreArchivo);
            if(!serializar)
            {
                BotonesDisponibles(false);
            }
            else
            {
                if (claseLapiz)
                {
                    SerializarListaLapiz(nombreArchivo);
                }
                else
                {
                    SerializarListaUtiles(nombreArchivo);
                }
            }
            
            
        }

        

        private void SerializarListaLapiz(string nombreArchivo)
        {
            List<Lapiz> listaLapices = unaCartuchera.MostrarListaLapices();
            //foreach (Lapiz unLapiz in listaLapices)
            //{
                ISerializa<Lapiz>.EscribirListaJson(listaLapices, nombreArchivo);
                MensajeGuardadoOk(); 
            //}
        }

        private void SerializarListaUtiles(string nombreArchivo)
        {
            //List<Util> listaUtiles = unaCartuchera.ListaUtiles;
            //foreach (Util unUtil in listaUtiles)
            //{
                ISerializa<Util>.EscribirListaJson(unaCartuchera.ListaUtiles, nombreArchivo);
                MensajeGuardadoOk();
            //}
        }

        private bool NombreArchivo(string nombreArchivo)
        {
            //string nombreArchivo = string.Empty;
            bool isEmpty = false; 
            if (string.IsNullOrEmpty(txb_nombreArchivo.Text))
            {
                MessageBox.Show("Ingrese un nombre de archivo para guardar", "Nombre archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //BotonesDisponibles(false);
                 
            }
            else
            {
                nombreArchivo = txb_nombreArchivo.Text;
                isEmpty = true;
                //BotonesDisponibles(true);
            }
            return isEmpty;
        }

        private void MensajeGuardadoOk()
        {
            MessageBox.Show($"Se ha guardado con éxito.");
        }

        private void BotonesDisponibles(bool enabled)
        {
            btn_json.Enabled = enabled;
            btn_xml.Enabled = enabled;
        }
        

        
    }
}
