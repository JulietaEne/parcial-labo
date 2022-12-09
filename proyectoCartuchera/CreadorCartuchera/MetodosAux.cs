using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace CreadorCartuchera
{
    public static class MetodosAux
    {
        public static void RestringirAInputNumerico(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void RestringirAInputAIntOFloat(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void AbrirFormAgregarUtiles(Cartuchera<Util> miCartuchera)
        {
            Frm_agregarUtiles formAgregarUtiles = new Frm_agregarUtiles(miCartuchera);
            formAgregarUtiles.ShowDialog();
        }

    }
}
