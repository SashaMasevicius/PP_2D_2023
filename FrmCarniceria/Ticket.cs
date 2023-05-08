using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCarniceria
{
    public partial class Ticket : Form
    {
        public Ticket(string mensaje, double precioTotalDeLaCompra, double dineroDisponible)
        {
            InitializeComponent();

            label1.Text = $"{mensaje} Total:{precioTotalDeLaCompra}$ \n Vuelto: {dineroDisponible}$ ";
        }

        private void buttonAceptarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
