using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjercicioXresolverSP2
{
    public partial class frmFerro : Form
    {
        public const int PrecioKm = 5;
        public const float Descuento = 50;

        public frmFerro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float PrecioConDescuento;
            float Total;

            if (int.Parse(txtDistancia.Text) >= 100 && nmrDias.Value >= 7)
            {

                PrecioConDescuento = int.Parse(txtDistancia.Text) * PrecioKm;
                Total = PrecioConDescuento - PrecioConDescuento * Descuento / 100;
                MessageBox.Show("El Precio a pagar es de: $" + PrecioConDescuento + " y el Total con descuento es de: $" + Total);
                lblMontoPrecio.Text = "El  precio con descuento es de: $" + PrecioConDescuento.ToString();
                lblMontoTotal.Text = "El monto final a pagar es de: $" + Total.ToString();
                btnCalcular.Enabled = false;
            }
            else
            {
                PrecioConDescuento = int.Parse(txtDistancia.Text) * PrecioKm;
                Total = PrecioConDescuento;

                MessageBox.Show("El Precio a pagar es de: $" + PrecioConDescuento + " y el Total sin descuento es de: $" + Total);
                lblMontoPrecio.Text = "El trayecto y los días elegidos no poseen descuento.";
                lblMontoTotal.Text = "El monto final a pagar es de: $" + Total.ToString();
                btnCalcular.Enabled = false;
            }
            nmrDias.Value = 1;
            txtDistancia.Text = "";
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtDistancia.Text == "")
            {
                btnCalcular.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
            
        }

        
    }
}
