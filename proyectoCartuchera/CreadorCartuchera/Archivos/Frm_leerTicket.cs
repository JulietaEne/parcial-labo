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
    }
}
