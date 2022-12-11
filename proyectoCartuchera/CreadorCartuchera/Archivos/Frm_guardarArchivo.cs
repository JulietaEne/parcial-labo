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
        public Frm_guardarArchivo(Cartuchera<Util> unaCartuchera)
        {
            InitializeComponent();
            this.unaCartuchera = unaCartuchera;
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            List<Lapiz> listaLapices = HallarLapicesEnCartuchera();
            foreach(Lapiz unLapiz in listaLapices)
            {
                ISerializa<Lapiz>.EscribirJson(unLapiz, "claseLapiz");
            }
        }

        private List<Lapiz> HallarLapicesEnCartuchera()
        {
            List<Lapiz> listaLapiz = new List<Lapiz>();

            foreach (Util unUtil in unaCartuchera.ListaUtiles)
            {
                if (unUtil is Lapiz)
                {
                    listaLapiz.Add((Lapiz)unUtil);
                }
            }
            return listaLapiz;
        }
    }
}
