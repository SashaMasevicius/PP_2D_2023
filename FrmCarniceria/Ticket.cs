using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FrmCarniceria
{
    public partial class Ticket : Form
    {

        private string archivoHistorial = "historial_ventas.txt";


        public Ticket(string mensaje, double precioTotalDeLaCompra, double dineroDisponible)
        {
            InitializeComponent();
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.AutoSize = false;
            label1.Width = 200;
            label1.Height = 150;
            label1.Text = $"{mensaje} Total:{precioTotalDeLaCompra}$ \n Vuelto: {dineroDisponible}$ ";
            GuardarHistorialVenta(label1.Text);
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
            //MessageBox.Show("Compra exitosa");
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

        private void GuardarHistorialVenta(string factura)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(archivoHistorial))
                {
                    sw.WriteLine(factura);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al guardar el historial de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
    }
}
