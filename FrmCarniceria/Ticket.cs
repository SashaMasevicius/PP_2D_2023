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
        /// <summary>
        /// boton que acepta la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/CompraBoton.wav";
            player.Play();
            MessageBox.Show("Compra exitosa");
            this.Close();
        }
        /// <summary>
        /// boton que cancela la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("Compra cancelada");
            this.Close();
        }
    }
}
