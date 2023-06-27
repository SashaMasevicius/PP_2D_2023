namespace FrmCarniceria
{
    public partial class Ticket : Form
    {

        private string archivoHistorial = "historial_ventas.txt";
        string resumenParaGuardarEnArchivo;

        public Ticket(string mensaje, double precioTotalDeLaCompra, double dineroDisponible)
        {
            InitializeComponent();
            this.Activate();

            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.AutoSize = false;
            label1.Width = 200;
            label1.Height = 150;
            label1.Text = $"{mensaje} Total:{precioTotalDeLaCompra}$ \n Vuelto: {dineroDisponible}$ ";
            resumenParaGuardarEnArchivo = $"{mensaje} Total:{precioTotalDeLaCompra}\n -----------------------\n";


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
            DateTime now = DateTime.Now;
            string fechaYHoraActual = now.ToString("dd/MM/yyyy HH:mm:ss");
            GuardarHistorialVenta($"{fechaYHoraActual}  \n {resumenParaGuardarEnArchivo}");


            //dejo comentado para ver ruta de archivo
            //string directorioActual = Directory.GetCurrentDirectory();
            //string rutaArchivo = Path.Combine(directorioActual, "historial_ventas.txt");

            //MessageBox.Show("La ubicación del archivo historial_ventas.txt es: " + rutaArchivo);


            this.Close();

        }

        /// <summary>
        /// 
        /// guardo historial de vernta
        /// </summary>
        /// <param name="factura"></param>
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

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
