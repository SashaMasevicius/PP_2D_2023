using Entidades;

namespace FrmCarniceria
{
    public partial class FrmComprador : Form
    {
        Comprador miComprador;
        Heladera miHeladera;
        bool validarPrecioParaComprar;
        bool validarMedioDePagoParaComprar;


        public FrmComprador()
        {
            InitializeComponent();

        }

        public FrmComprador(Comprador comprador) : this()
        {
            this.miComprador = comprador;
            MessageBox.Show(miComprador.crearMensajeBienvenido());


            List<Producto> listaDeProductos;

            //harcodeo productos para agregar a la heladera

            Producto prodUno = new Producto(eCarne.Asado, 100, 2000);
            Producto prodDos = new Producto(eCarne.Vacio, 150, 2200);
            Producto prodTres = new Producto(eCarne.Matambre, 120, 2500);
            Producto prodCuatro = new Producto(eCarne.Chorizo, 40, 1500);


            //creo una lista del tipo producto

            listaDeProductos = new List<Producto>();
            listaDeProductos.Add(prodUno);
            listaDeProductos.Add(prodDos);
            listaDeProductos.Add(prodTres);
            listaDeProductos.Add(prodCuatro);



            //instancio el objeto heladera

            miHeladera = new Heladera(listaDeProductos);

            this.labelBienvenido.Text = labelBienvenido.Text + " " + this.miComprador.Email;
            this.labelDatos.Text = miHeladera.mostrarDetalleDeProductos();
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



        /// <summary>
        /// Boton para ingresar medio de pago y mostrar mensaje, el monto queda guardado en la pantalla para que sea visible al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarMedioDePago_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            if (this.radioButtonTarjeta.Checked == true)
            {
                MessageBox.Show("El medio de pago elegido es: TARJETA");
                this.labelMedioDePago.Text = "TARJETA";
                validarMedioDePagoParaComprar = true;

            }
            else
            {
                MessageBox.Show("El medio de pago elegido es: EFECTIVO");
                this.labelMedioDePago.Text = "EFECTIVO";
                validarMedioDePagoParaComprar = true;
            }



        }



        /// <summary>
        /// Boton para realizar la compra y mostrar el ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            int kilosAsado = (int)this.numericUpDownKilosAsado.Value;
            int kilosVacio = (int)this.numericUpDownKilosVacio.Value;
            int kilosMatambre = (int)this.numericUpDownKilosMatambre.Value;
            int kilosChorizo = (int)this.numericUpDownKilosChorizo.Value;


            double obtenerPrecioAsado = miHeladera.obtenerPrecio(0);
            double obtenerPrecioVacio = miHeladera.obtenerPrecio(1);
            double obtenerPrecioMatambre = miHeladera.obtenerPrecio(2);
            double obtenerPrecioChorizo = miHeladera.obtenerPrecio(3);

            // Obtener el texto del Label
            string textoLabel = labelpPrecioDisponibleIngresado.Text;

            // Convertir el texto en un número decimal
            double dineroDisponible;
            Double.TryParse(textoLabel, out dineroDisponible);



            double precioAsadoPorKilosElegidos = 0;
            double precioVacioPorKilosElegidos = 0;
            double precioMatambrePorKilosElegidos = 0;
            double precioChorizoPorKilosElegidos = 0;
            double precioTotalDeLaCompra = 0;

            int retornoStockAsado = 1;
            int retornoStockVacio = 1;
            int retornoStockMatambre = 1;
            int retornoStockChorizo = 1;

            string mensaje = "Detalles de su compra: \n";

            if (validarPrecioParaComprar == false && validarMedioDePagoParaComprar == false)
            {
                MessageBox.Show("ERROR: Debe ingresar monto y medio de pago para poder realizar la compra");
            }
            else
            {
                // busco el precio de cada corte elegido por el usuario y lo multiplico por los kilos, el valor final de cada producto lo sumo y
                // lo guardo en su atributo
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
                    retornoStockMatambre = miComprador.ValidarKilosEnStock(miHeladera, kilosChorizo, 3, 3);

                }
                precioTotalDeLaCompra = precioAsadoPorKilosElegidos + precioVacioPorKilosElegidos + precioMatambrePorKilosElegidos + precioChorizoPorKilosElegidos;

                if (retornoStockAsado == 1 && retornoStockVacio == 1 && retornoStockMatambre == 1 && retornoStockChorizo == 1)
                {


                    if (dineroDisponible >= precioTotalDeLaCompra)
                    {
                        //si es tarjeta
                        if (this.radioButtonTarjeta.Checked == true)
                        {

                            precioTotalDeLaCompra = precioTotalDeLaCompra + precioTotalDeLaCompra * 0.05;
                            dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                            if (dineroDisponible >= precioTotalDeLaCompra)
                            {

                                //abro formulario ticket de venta
                                Ticket frmTicket = new Ticket(mensaje, precioTotalDeLaCompra, dineroDisponible);
                                DialogResult result = frmTicket.ShowDialog();


                                if (result == DialogResult.OK)
                                {
                                    //dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                                    // si todo esta ok . resto los kilos al stock
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

                                    // actualizo datos de label
                                    this.labelDatos.Text = miHeladera.mostrarDetalleDeProductos();
                                    labelpPrecioDisponibleIngresado.Text = "";
                                    labelMedioDePago.Text = "";
                                }



                            }
                            else
                            {
                                MessageBox.Show("Error, no tiene suficiente dinero para realizar la compra");
                            }




                        }




                        if (this.radioButtonEfectivo.Checked == true)
                        {
                            dineroDisponible = dineroDisponible - precioTotalDeLaCompra;

                            Ticket frmTicket = new Ticket(mensaje, precioTotalDeLaCompra, dineroDisponible);
                            DialogResult result = frmTicket.ShowDialog();


                            if (result == DialogResult.OK)
                            {

                                // si todo esta ok . resto los kilos al stock
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

                                // actualizo datos de label
                                this.labelDatos.Text = miHeladera.mostrarDetalleDeProductos();
                                labelpPrecioDisponibleIngresado.Text = "";
                                labelMedioDePago.Text = "";

                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, no tiene suficiente dinero para realizar la compra");
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
            FrmIniciarSesion formularioIniciarSesion;
            formularioIniciarSesion = new FrmIniciarSesion();
            formularioIniciarSesion.Show();
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





        // quitar
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

    }
}
