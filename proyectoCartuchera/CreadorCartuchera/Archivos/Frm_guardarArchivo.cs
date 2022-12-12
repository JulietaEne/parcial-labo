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
using ManejadorDeArchivos; 

namespace CreadorCartuchera
{
    public partial class Frm_guardarArchivo : Form
    {
        Cartuchera<Util> unaCartuchera;
        //bool serializarClaseLapiz; 
        public Frm_guardarArchivo(Cartuchera<Util> unaCartuchera)
        {
            InitializeComponent();
            this.unaCartuchera = unaCartuchera;
            //serializarClaseLapiz = true; 
            
        }
        private void Frm_guardarArchivo_Load(object sender, EventArgs e)
        {
            gb_tipoArchivo.Visible = false;
            lbl_mensaje.Text = "Indique qué desea guardar";
            lbl_mensaje.Visible = false;    
            gb_tipoArchivo.Visible = false; 
        }
        private void gb_dato_Enter(object sender, EventArgs e)
        {
            
            gb_tipoArchivo.Visible = true; 
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            string nombreArchivo = string.Empty;
            if (string.IsNullOrEmpty(txb_nombreArchivo.Text))
            {
                MessageBox.Show("Ingrese un nombre de archivo para guardar", "Nombre archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nombreArchivo = NombreArchivo();
                if (rbtn_cartuchera.Checked)
                {
                    //serializarClaseLapiz = false;
                    //lbl_mensaje.Text = "Guardar cartuchera";

                    JsonListaUtiles(nombreArchivo); 
                }
                else
                {
                    JsonListaLapiz(nombreArchivo);
                }
            }
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            string nombreArchivo = string.Empty;
            if (string.IsNullOrEmpty(txb_nombreArchivo.Text))
            {
                MessageBox.Show("Ingrese un nombre de archivo para guardar", "Nombre archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nombreArchivo = NombreArchivo();
                if (rbtn_cartuchera.Checked)
                {
                    //serializarClaseLapiz = false;
                    //lbl_mensaje.Text = "Guardar cartuchera";
                    XmlListaLapiz(nombreArchivo);
                }
                else
                {
                    XmlListaLapiz(nombreArchivo);
                }
            } 
               
            
        }

        

        private void JsonListaLapiz(string nombreArchivo)
        {
            List<Lapiz> listaLapices = unaCartuchera.MostrarListaLapices();
            if(listaLapices.Count > 0)
            {
                ISerializa<Lapiz>.EscribirListaJson(listaLapices, nombreArchivo);
                MensajeGuardadoOk();
            }
            else
            {
                MessageBox.Show($"La cartuchera no tiene Lápiz");
            }
            
        }

        private void JsonListaUtiles(string nombreArchivo)
        {
            List<Util> listaUtiles = unaCartuchera.ListaUtiles;
            ISerializa<Util>.EscribirListaJson(listaUtiles, nombreArchivo);
            MensajeGuardadoOk();
        }

        private string NombreArchivo()
        {
            return  txb_nombreArchivo.Text;
        }

        private void MensajeGuardadoOk()
        {
            MessageBox.Show("Se ha guardado con éxito.");
        }

       

        private void XmlListaLapiz(string nombreArchivo)
        {
            List<Lapiz> listaLapices = unaCartuchera.MostrarListaLapices();
            ISerializa<Lapiz>.EscribirListaXml(listaLapices, nombreArchivo);
            MensajeGuardadoOk();
        }

        private void XmlListaUtiles(string nombreArchivo)
        {
            List<Util> listaUtiles = unaCartuchera.ListaUtiles;
            ISerializa<Util>.EscribirListaXml(listaUtiles, nombreArchivo);
            MensajeGuardadoOk();
        }

    }
}
