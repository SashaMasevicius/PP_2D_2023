using Entidades;
using System.Windows.Forms;

namespace FrmCarniceria
{
    public partial class FrmComprador : Form
    {
        Comprador miComprador;
        Heladera miHeladera;
        bool validarPrecioParaComprar;
        bool validarMedioDePagoParaComprar;
        List<VentasHistorial> listaVentas;

        public event Action saldoInsuficiente;



        public FrmComprador()
        {
            InitializeComponent();

        }

        public FrmComprador(Comprador comprador, Heladera miHeladera) : this()
        {
            this.miComprador = comprador;
            MessageBox.Show(miComprador.crearMensajeBienvenido());
            this.miHeladera = miHeladera;

            MostrarStock();
            saldoInsuficiente += ActualizarHerramientas;
            saldoInsuficiente += ventanaEmergente;
            this.Load += CargarHilo;
        }


        private void MostrarStock()
        {
            // Llamar al método mostrarDetalleDeProductos y obtener el resultado
            string detallesProductos = miHeladera.mostrarDetalleDeProductos();

            // Asignar el resultado al DataSource del ListBox
            listBox1Stock.DataSource = detallesProductos.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        }

        /// <summary>
        /// Boton para ingresar dinero y mostrar mensaje, el monto queda guardado en la pantalla para que sea visible al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptarDineroDisponible_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            string montoDisponibleStr = textBoxDineroDisponible.Text;
            double montoDisponible;

            if (Comprador.validarPrecioDisponible(montoDisponibleStr) == -1)
            {
                MessageBox.Show("Error, el numero ingresado no es valido");
            }
            else
            {
                montoDisponible = Comprador.validarPrecioDisponible(montoDisponibleStr);
                MessageBox.Show($"Tu dinero disponible es : {montoDisponible}");
                labelpPrecioDisponibleIngresado.Text = montoDisponibleStr;
                validarPrecioParaComprar = true;

            }


        }




        // variables para metodos siguientes

        double precioTotalDeLaCompra = 0;
        int retornoStockAsado = 1;
        int retornoStockVacio = 1;
        int retornoStockMatambre = 1;
        int retornoStockChorizo = 1;
        string mensaje = "Detalles de su compra: \n";

        /// <summary>
        /// 
        /// Obtiene el precio por kilo sumado, y el precio final de cada corte por kg. devuelve mensaje para utilizar en el ticket
        /// </summary>
        /// <returns></returns>
        private string ObtenerPrecioTotalDeLaCompraDevolverMensaje()
        {

            double precioAsadoPorKilosElegidos = 0;
            double precioVacioPorKilosElegidos = 0;
            double precioMatambrePorKilosElegidos = 0;
            double precioChorizoPorKilosElegidos = 0;


            int kilosAsado = (int)this.numericUpDownKilosAsado.Value;
            int kilosVacio = (int)this.numericUpDownKilosVacio.Value;
            int kilosMatambre = (int)this.numericUpDownKilosMatambre.Value;
            int kilosChorizo = (int)this.numericUpDownKilosChorizo.Value;

            double obtenerPrecioAsado = miHeladera.obtenerPrecio(0);
            double obtenerPrecioVacio = miHeladera.obtenerPrecio(1);
            double obtenerPrecioMatambre = miHeladera.obtenerPrecio(2);
            double obtenerPrecioChorizo = miHeladera.obtenerPrecio(3);



            string mensaje = "Detalles de su compra: \n";

            if (this.checkBoxAsado.Checked)
            {
                precioAsadoPorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosAsado, 0, 0, obtenerPrecioAsado);
                mensaje = mensaje + $"Asado" + kilosAsado.ToString() + " Kg" + " = " + precioAsadoPorKilosElegidos + "$\n";
                retornoStockAsado = miComprador.ValidarKilosEnStock(miHeladera, kilosAsado, 0, 0);
            }
            if (this.checkBoxVacio.Checked)
            {
                precioVacioPorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosVacio, 1, 1, obtenerPrecioVacio);
                mensaje = mensaje + $"Vacio" + kilosVacio.ToString() + " Kg" + " = " + precioVacioPorKilosElegidos + "$\n";
                retornoStockVacio = miComprador.ValidarKilosEnStock(miHeladera, kilosVacio, 1, 1);
            }
            if (this.checkBoxMatambre.Checked)
            {
                precioMatambrePorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosMatambre, 2, 2, obtenerPrecioMatambre);
                mensaje = mensaje + $"Matambre" + kilosMatambre.ToString() + " Kg" + " = " + precioMatambrePorKilosElegidos + "$\n";
                retornoStockMatambre = miComprador.ValidarKilosEnStock(miHeladera, kilosMatambre, 2, 2);
            }
            if (this.checkBoxChorizo.Checked)
            {
                precioChorizoPorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosChorizo, 3, 3, obtenerPrecioChorizo);
                mensaje = mensaje + $"Chorizo" + kilosChorizo.ToString() + " Kg" + " = " + precioChorizoPorKilosElegidos + "$ \n";
                retornoStockChorizo = miComprador.ValidarKilosEnStock(miHeladera, kilosChorizo, 3, 3);

            }
            precioTotalDeLaCompra = precioAsadoPorKilosElegidos + precioVacioPorKilosElegidos + precioMatambrePorKilosElegidos + precioChorizoPorKilosElegidos;
            return mensaje;
        }

        /// <summary>
        /// 
        /// disminuye kg de cortes elegidos
        /// </summary>
        public void RestarKilosAlStockSegunCorte()
        {
            int kilosAsado = (int)this.numericUpDownKilosAsado.Value;
            int kilosVacio = (int)this.numericUpDownKilosVacio.Value;
            int kilosMatambre = (int)this.numericUpDownKilosMatambre.Value;
            int kilosChorizo = (int)this.numericUpDownKilosChorizo.Value;



            double obtenerPrecioAsado = miHeladera.obtenerPrecio(0);
            double obtenerPrecioVacio = miHeladera.obtenerPrecio(1);
            double obtenerPrecioMatambre = miHeladera.obtenerPrecio(2);
            double obtenerPrecioChorizo = miHeladera.obtenerPrecio(3);

            if (this.checkBoxAsado.Checked)
            {
                miComprador.RestarKilosAlStock(miHeladera, kilosAsado, 0, 0, obtenerPrecioAsado);

            }
            if (this.checkBoxVacio.Checked)
            {
                miComprador.RestarKilosAlStock(miHeladera, kilosVacio, 1, 1, obtenerPrecioVacio);

            }
            if (this.checkBoxMatambre.Checked)
            {
                miComprador.RestarKilosAlStock(miHeladera, kilosMatambre, 2, 2, obtenerPrecioMatambre);

            }
            if (this.checkBoxChorizo.Checked)
            {
                miComprador.RestarKilosAlStock(miHeladera, kilosChorizo, 3, 3, obtenerPrecioChorizo);


            }
        }
        /// <summary>
        /// Acepta compra realizada y disminuye stock
        /// </summary>
        /// <param name="dineroDisponible"></param>
        public void aceptarCompraIngresandoANuevoFormularioRestarKilos(double dineroDisponible)
        {

            Ticket frmTicket = new Ticket(mensaje, precioTotalDeLaCompra, dineroDisponible);
            DialogResult result = frmTicket.ShowDialog();

            if (result == DialogResult.OK)
            {
                //dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                // si todo esta ok . resto los kilos al stock

                RestarKilosAlStockSegunCorte();

                // actualizo datos de stock
                MostrarStock();
                ActualizarHerramientas();

            }

        }


        /// <summary>
        /// Boton para realizar la compra y mostrar el ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            // Obtener el texto del Label
            string textoLabel = labelpPrecioDisponibleIngresado.Text;
            double dineroDisponible;
            Double.TryParse(textoLabel, out dineroDisponible);


            // si no  elige precio y medio de pago
            if (validarPrecioParaComprar == false && validarMedioDePagoParaComprar == false)
            {
                MessageBox.Show("ERROR: Debe ingresar monto y medio de pago para poder realizar la compra");
            }
            else //si   elige precio y medio de pago
            {
                //guardoMensaje y guarrdo precioDeLaCompra
                mensaje = ObtenerPrecioTotalDeLaCompraDevolverMensaje();

                // si todos los retornos dan 1
                if (retornoStockAsado == 1 && retornoStockVacio == 1 && retornoStockMatambre == 1 && retornoStockChorizo == 1)
                {

                    //si es tarjeta
                    if (this.radioButtonTarjeta.Checked == true)
                    {
                        precioTotalDeLaCompra = precioTotalDeLaCompra + precioTotalDeLaCompra * 0.05;

                        if (dineroDisponible >= precioTotalDeLaCompra)
                        {
                            dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                            aceptarCompraIngresandoANuevoFormularioRestarKilos(dineroDisponible);
                            VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDinero, MostrarMensajeDinero);
                        }
                        else
                        {
                            VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDinero, MostrarMensajeDinero);

                        }
                    } // si es efectivo
                    if (this.radioButtonEfectivo.Checked == true)
                    {
                        if (dineroDisponible >= precioTotalDeLaCompra)
                        {
                            dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                            aceptarCompraIngresandoANuevoFormularioRestarKilos(dineroDisponible);
                            VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDinero, MostrarMensajeDinero);

                        }
                        else
                        {
                            VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDinero, MostrarMensajeDinero);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, compraste mas kilos de los que hay en stock, verifica la cantidad disponible");
                }
            }




        }




        /// <summary>
        /// 
        /// vuelve al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            //FrmIniciarSesion formularioIniciarSesion;
            //formularioIniciarSesion = new FrmIniciarSesion();
            //formularioIniciarSesion.
            this.Hide();
        }
        /// <summary>
        /// autocompletar datos para prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAutoCompletDatos_Click(object sender, EventArgs e)
        {
            textBoxDineroDisponible.Text = "50000";
            radioButtonTarjeta.Checked = true;
            checkBoxAsado.Checked = true;
            checkBoxMatambre.Checked = true;
            numericUpDownKilosAsado.Value = 5;
            numericUpDownKilosMatambre.Value = 4;

        }

        /// <summary>
        /// verifica dinero y lanza mensaje error,exito
        /// </summary>
        /// <param name="dineroDisponible"></param>
        /// <param name="TieneDinero"></param>
        /// <param name="NoTieneDinero"></param>
        public void VerificarDineroDelCliente(double dineroDisponible, Action<string> TieneDinero, Action<string> NoTieneDinero)
        {
            if (dineroDisponible <= precioTotalDeLaCompra)
            {
                NoTieneDinero.Invoke("Error, no tiene suficiente dinero para realizar la compra");
                saldoInsuficiente?.Invoke();

            }
            else
            {
                TieneDinero.Invoke("Compra Exitosa");
            }

        }
        /// <summary>
        /// Mostrar mensaje para metodo verificar dinero
        /// </summary>
        /// <param name="mensaje"></param>
        public void MostrarMensajeDinero(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ActualizarHerramientas()
        {
            textBoxDineroDisponible.Text = "0";
            radioButtonTarjeta.Checked = false;
            checkBoxAsado.Checked = false;
            checkBoxMatambre.Checked = false;
            numericUpDownKilosAsado.Value = 1;
            numericUpDownKilosVacio.Value = 1;
            numericUpDownKilosMatambre.Value = 1;
            numericUpDownKilosChorizo.Value = 1;
            labelpPrecioDisponibleIngresado.Text = "";
        }

        public void ventanaEmergente()
        {
            DialogResult result = MessageBox.Show("No tienes suficiente dinero para continuar la compra.\n\n¿Deseas volver al menu anterior y volver a realizar la compra?", "Mensaje de Alerta", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                // Acciones cuando se selecciona "Sí" (cargar saldo)
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Compra cancelada contacte con el vendedor para otras formas de pago\n CONTACTO : 9999-2121");
                this.Close();
            }

        }
        /// <summary>
        /// 
        /// meotdo para mostrar imagenes de publicidad en un hilo secundario
        /// </summary>
        private void MostrarHiloSecundarioPublicidad()
        {
            while (true)
            {
                while (true)
                {
                    // si el control fue eliminado salgo del bucle
                    if (pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                    {
                      
                        break;
                    }

                    // primer imagen // si no fue eliminado
                    if (!pictureBox1.IsDisposed)
                    {
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = true));
                    }

                    Thread.Sleep(1500);

                    // oculto primer imagen
                    if (!pictureBox1.IsDisposed)
                    {
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
                    }

                    Thread.Sleep(1500);

                    // Msegunda imagen
                    if (!pictureBox2.IsDisposed)
                    {
                        pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Visible = true));
                    }

                    // Esperar 10 segundos
                    Thread.Sleep(1500);

                    // oculto segunda imagen
                    if (!pictureBox2.IsDisposed)
                    {
                        pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Visible = false));
                    }
                }
            }
        }

        private void CargarHilo(object sender, EventArgs e)
        {
            Thread publicidadThread = new Thread(MostrarHiloSecundarioPublicidad);
            publicidadThread.Start();
        }


        #region HerramientasNoUtilizadas


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelDatos_Click(object sender, EventArgs e)
        {

        }

        private void labelBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmComprador_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxCortes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
