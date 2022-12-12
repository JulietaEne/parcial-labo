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

namespace CreadorCartuchera.Archivos
{
    public partial class Frm_leerTicket : Form
    {
        public Frm_leerTicket()
        {
            InitializeComponent();
        }

        private void Frm_leerTicket_Load(object sender, EventArgs e)
        {
            rtxb_leerTicket.Text = ManejadorArchivos.LeerArchivo("ticket");
            lbl_ruta.Text = $"Archivo guardado en: {ManejadorArchivos.Ruta}/ticket.log";
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtxb_leerTicket.Text = ManejadorArchivos.LeerArchivoIndicado(openFileDialog1.FileName);
                    lbl_ruta.Text = $"Archivo guardado en: {openFileDialog1.FileName}";
                }
                catch(Exception)
                {
                    MessageBox.Show("Imposible abrir archivo solicitado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
