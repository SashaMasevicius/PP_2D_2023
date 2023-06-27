using Entidades;
using System.Text;

namespace FrmCarniceria
{
    public partial class FrmCliente : Form
    {
        Comprador miComprador;
        Heladera miHeladera;
        bool validarPrecioParaComprar;
        public event Action saldoInsuficiente;


        public FrmCliente()
        {
            InitializeComponent();
        }

        public FrmCliente(Comprador comprador, Heladera miHeladera) : this()
        {
            this.miComprador = comprador;
            MessageBox.Show(miComprador.crearMensajeBienvenido());
            this.miHeladera = miHeladera;


            MostrarStock();
            saldoInsuficiente += ActualizarHerramientas;
            saldoInsuficiente += ventanaEmergente;
            this.Load += CargarHilo;
        }


        public void MostrarStock()
        {
            List<Producto> miProducto = CrudStock.Leer();

            // Limpiar el DataGridView
            dataGridView12.Rows.Clear();

            // Agregar cada producto al DataGridView
            foreach (Producto producto in miProducto)
            {
                dataGridView12.Rows.Add(producto.TipoCarne, producto.Peso, producto.PrecioPorKg);
            }

        }
        /// <summary>
        /// Boton para ingresar dinero y mostrar mensaje, el monto queda guardado en la pantalla para que sea visible al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDineroDisponible_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            string montoDisponibleStr = textBoxDinero.Text;
            double montoDisponible;

            if (Comprador.validarPrecioDisponible(montoDisponibleStr) == -1)
            {
                MessageBox.Show("Error, el numero ingresado no es valido");
            }
            else
            {
                montoDisponible = Comprador.validarPrecioDisponible(montoDisponibleStr);
                MessageBox.Show($"Tu dinero disponible es : {montoDisponible}");
                label1.Text = montoDisponibleStr;
                validarPrecioParaComprar = true;

            }
        }

        private void IngresarFrmNuevoTicket()
        {
            double dineroDisponible;
            double precioFinal = CalcularPrecioConYSinDescuento();
            if (double.TryParse(textBoxDinero.Text, out dineroDisponible))
            {

                double vuelto = dineroDisponible - precioFinal;
                if (dineroDisponible > precioFinal)
                {
                    Ticket frmTicket = new Ticket(ObtenerMensajeDeCompra(), precioFinal, vuelto);
                    frmTicket.Show();
                    RestarKilosPorCorte();
                    ActualizarHerramientas();
                    VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDeDinero, MostrarMensajeDeDinero);

                }
                else
                {
                    VerificarDineroDelCliente(dineroDisponible, MostrarMensajeDeDinero, MostrarMensajeDeDinero);

                }



            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        /// <summary>
        /// boton que desencadena en la compra del prpoducto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComprar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();


            double dineroDisponible;

            double.TryParse(textBoxDinero.Text, out dineroDisponible);


            if (ValidarSeleccionMedioDePago() == true)
            {
                if (ValidarSeleccionDeOpcionesDeCarne() == true)
                {



                    IngresarFrmNuevoTicket();

                }
                else
                {
                    MessageBox.Show("Tenes que seleccionar al menos un corte para continuar");

                }

            }
            else
            {
                MessageBox.Show("Tenes que ingresar un medio de pago para continuar");
            }

        }

        /// <summary>
        /// precio por kilo seleccionado
        /// </summary>
        /// <returns></returns>
        public double ObtenerPrecioAsadoPorKilo()
        {
            int cantidadKilosSeleccionado = (int)numericUpDownAsado.Value;
            Producto productoExistente = CrudStock.ObtenerProductoPorId(1);
            double precioAsado = productoExistente.PrecioPorKg;
            double PrecioVendido = precioAsado * cantidadKilosSeleccionado;
            return PrecioVendido;
        }
        /// <summary>
        /// precio por kilo seleccionado
        /// </summary>
        /// <returns></returns>
        public double ObtenerPrecioVacioPorKilo()
        {
            int cantidadKilosSeleccionado = (int)numericUpDownVacio.Value;
            Producto productoExistente = CrudStock.ObtenerProductoPorId(2);
            double precioVacio = productoExistente.PrecioPorKg;
            double PrecioVendido = precioVacio * cantidadKilosSeleccionado;
            return PrecioVendido;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double ObtenerPrecioMatambrePorKilo()
        {
            int cantidadKilosSeleccionado = (int)numericUpDownMatambre.Value;
            Producto productoExistente = CrudStock.ObtenerProductoPorId(3);
            double precioAsado = productoExistente.PrecioPorKg;
            double PrecioMatambre = precioAsado * cantidadKilosSeleccionado;
            return PrecioMatambre;
        }

        /// <summary>
        /// precio por kilo seleccionado
        /// </summary>
        /// <returns></returns>
        public double ObtenerPrecioChorizoPorKilo()
        {
            int cantidadKilosSeleccionado = (int)numericUpDownChorizo.Value;
            Producto productoExistente = CrudStock.ObtenerProductoPorId(4);
            double precioChorizo = productoExistente.PrecioPorKg;
            double PrecioVendido = precioChorizo * cantidadKilosSeleccionado;
            return PrecioVendido;
        }

        /// <summary>
        /// resto kilos al corte para el stock
        /// </summary>
        public void RestarKilosPorCorte()
        {

            if (this.checkBoxAsado.Checked)
            {

                Producto productoExistente = CrudStock.ObtenerProductoPorId(1);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosAsado = (int)numericUpDownAsado.Value;
                int PesoTotalA = PesoAnterior - cantidadKilosAsado;
                double precioActualA = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalA, precioActualA);
                productoModificado.id = 1;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }
            if (this.checkBoxVacio.Checked)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(2);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosVacio = (int)numericUpDownVacio.Value;
                int PesoTotalV = PesoAnterior - cantidadKilosVacio;
                double precioActualV = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalV, precioActualV);
                productoModificado.id = 2;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }
            if (this.checkBoxMatambre.Checked)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(3);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosMatambre = (int)numericUpDownMatambre.Value;
                int PesoTotalM = PesoAnterior - cantidadKilosMatambre;
                double precioActualM = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalM, precioActualM);
                productoModificado.id = 3;
                CrudStock.Modificar(productoModificado);


                MostrarStock();
            }
            if (this.checkBoxChorizo.Checked)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(4);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosChorizo = (int)numericUpDownChorizo.Value;
                int PesoTotalC = PesoAnterior - cantidadKilosChorizo;
                double precioActualC = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalC, precioActualC);
                productoModificado.id = 4;
                CrudStock.Modificar(productoModificado);


                MostrarStock();
            }
        }
        /// <summary>
        /// obtengo el precio total de la compra (suma de la compra de toods los cortes)
        /// </summary>
        /// <returns></returns>
        public double ObtenerPrecioTotalDeCompra()
        {
            double asado = 0;
            double vacio = 0;
            double matambre = 0;
            double chorizo = 0;
            double precioFinal;
            if (this.checkBoxAsado.Checked)
            {
                asado = ObtenerPrecioAsadoPorKilo();
            }
            if (this.checkBoxVacio.Checked)
            {
                vacio = ObtenerPrecioVacioPorKilo();
            }
            if (this.checkBoxMatambre.Checked)
            {
                matambre = ObtenerPrecioMatambrePorKilo();
            }
            if (this.checkBoxChorizo.Checked)
            {
                chorizo = ObtenerPrecioChorizoPorKilo();

            }
            precioFinal = asado + vacio + matambre + chorizo;
            return precioFinal;
        }
        /// <summary>
        /// calculo precio con y sin descuento ( tarjeta 5 % mas)
        /// </summary>
        /// <returns></returns>
        private double CalcularPrecioConYSinDescuento()
        {
            if (radioButtonTarjeta.Checked == true)
            {
                return ObtenerPrecioTotalDeCompra() + ObtenerPrecioTotalDeCompra() * 0.05;
            }
            else if (radioButtonEfectivo.Checked == true)
            {
                return ObtenerPrecioTotalDeCompra();

            }

            return 0;
        }

        /// <summary>
        /// mensaje para ticket
        /// </summary>
        /// <returns></returns>
        public string ObtenerMensajeDeCompra()
        {

            int cantidadKilosAsado = (int)numericUpDownAsado.Value;
            int cantidadKilosVacio = (int)numericUpDownVacio.Value;
            int cantidadKilosMatambre = (int)numericUpDownMatambre.Value;
            int cantidadKilosChorizo = (int)numericUpDownChorizo.Value;


            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Detalle de compra:");
            if (this.checkBoxAsado.Checked)
            {
                sb.AppendLine($"Asado KG {cantidadKilosAsado} = {ObtenerPrecioAsadoPorKilo()}  ");
            }
            if (this.checkBoxVacio.Checked)
            {
                sb.AppendLine($"Vacio KG {cantidadKilosVacio} = {ObtenerPrecioVacioPorKilo()}  ");
            }
            if (this.checkBoxMatambre.Checked)
            {
                sb.AppendLine($"Matambre KG {cantidadKilosMatambre} = {ObtenerPrecioMatambrePorKilo()}  ");
            }
            if (this.checkBoxChorizo.Checked)
            {
                sb.AppendLine($"Chorizo KG {cantidadKilosChorizo} = {ObtenerPrecioChorizoPorKilo()}  ");

            }

            return sb.ToString();
        }
        /// <summary>
        /// actualizo herramientas
        /// </summary>
        public void ActualizarHerramientas()
        {
            textBoxDinero.Text = "0";
            radioButtonTarjeta.Checked = false;
            checkBoxAsado.Checked = false;
            checkBoxMatambre.Checked = false;
            checkBoxVacio.Checked = false;
            checkBoxChorizo.Checked = false;
            numericUpDownAsado.Value = 1;
            numericUpDownVacio.Value = 1;
            numericUpDownMatambre.Value = 1;
            numericUpDownChorizo.Value = 1;
            label1.Text = "";
        }
        /// <summary>
        /// valido medio de pago
        /// </summary>
        /// <returns></returns>
        public bool ValidarSeleccionMedioDePago()
        {
            if (radioButtonTarjeta.Checked == false && radioButtonEfectivo.Checked == false)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// valido que seleccione algun corte
        /// </summary>
        /// <returns></returns>
        public bool ValidarSeleccionDeOpcionesDeCarne()
        {
            if (this.checkBoxAsado.Checked == false && this.checkBoxVacio.Checked == false
                && this.checkBoxMatambre.Checked == false && this.checkBoxChorizo.Checked == false)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// verifica si tiene dinero y si no envia mensajes corresopndientes
        /// </summary>
        /// <param name="dineroDisponible"></param>
        /// <param name="TieneDinero"></param>
        /// <param name="NoTieneDinero"></param>
        public void VerificarDineroDelCliente(double dineroDisponible, Action<string> TieneDinero, Action<string> NoTieneDinero)
        {

            if (dineroDisponible <= CalcularPrecioConYSinDescuento())
            {

                NoTieneDinero.Invoke("Error, no tiene suficiente dinero para realizar la compra");
                saldoInsuficiente?.Invoke();

            }
            else
            {

                TieneDinero.Invoke("Ya estas terminando tu compra");
            }

        }
        /// <summary>
        /// se usa para mostrar mensajes en actions
        /// </summary>
        /// <param name="mensaje"></param>
        public void MostrarMensajeDeDinero(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        /// <summary>
        /// ventana emergente cuando no posee dinero
        /// </summary>
        public void ventanaEmergente()
        {
            DialogResult result = MessageBox.Show("No tienes suficiente dinero para continuar la compra.\n\n¿Deseas realizar otra compra?", "Mensaje de Alerta", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Compra cancelada contacte con el vendedor para otras formas de pago\n CONTACTO : 9999-2121");
                this.Close();
            }

        }
        /// <summary>
        /// Mostrar publicidad en un hilo secundario
        /// </summary>
        private async void MostrarHiloSecundarioPublicidad()
        {
            try
            {
                if (this.IsDisposed || pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                    return;

                while (true)
                {
                    try
                    {
                        if (this.IsDisposed || pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                            break;

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = true));
                        await Task.Delay(1500);

                        if (this.IsDisposed || pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                            break;

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Visible = false));
                        await Task.Delay(1500);

                        if (this.IsDisposed || pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                            break;

                        pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Visible = true));
                        await Task.Delay(10000);

                        if (this.IsDisposed || pictureBox1.IsDisposed || pictureBox2.IsDisposed)
                            break;

                        pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Visible = false));
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show("Se ha producido un error en el hilo de publicidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error al iniciar el hilo de publicidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// cargar nuevo hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarHilo(object sender, EventArgs e)
        {
            Thread publicidadThread = new Thread(MostrarHiloSecundarioPublicidad);
            publicidadThread.Start();
        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// boton para autocompletar datos (prueba)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDinero.Text = "50000";
            radioButtonTarjeta.Checked = true;
            checkBoxAsado.Checked = true;
            checkBoxMatambre.Checked = true;
            numericUpDownAsado.Value = 5;
            numericUpDownMatambre.Value = 4;
        }
    }


}
