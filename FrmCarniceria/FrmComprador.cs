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
            MessageBox.Show($"Bienvenido {this.miComprador.Email}");


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
         
            if(this.radioButtonTarjeta.Checked == true)
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

            string mensaje = "COMPRA REALIZADA: ";

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
                    mensaje = mensaje + $"Asado" + kilosAsado.ToString() + "Kg" + "=" + precioAsadoPorKilosElegidos;
                }
                if (this.checkBoxVacio.Checked)
                {
                    precioVacioPorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosVacio, 1, 1, obtenerPrecioVacio);
                    mensaje = mensaje + $"Vacio" + kilosVacio.ToString() + "Kg" + "=" + precioVacioPorKilosElegidos;
                }
                if (this.checkBoxMatambre.Checked)
                {
                    precioMatambrePorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosMatambre, 2, 2, obtenerPrecioMatambre);
                    mensaje = mensaje + $"Matambre" + kilosMatambre.ToString() + "Kg" + "=" + precioMatambrePorKilosElegidos;
                }
                if (this.checkBoxChorizo.Checked)
                {
                    precioChorizoPorKilosElegidos = miComprador.obtenerPrecioCortePorKilo(miHeladera, kilosChorizo, 3, 3, obtenerPrecioChorizo);
                    mensaje = mensaje + $"Chorizo" + kilosChorizo.ToString() + "Kg" + "=" + precioChorizoPorKilosElegidos;
                }

                if (dineroDisponible >= precioTotalDeLaCompra)
                {
                    if (this.radioButtonTarjeta.Checked == true)
                    {
                        precioTotalDeLaCompra = precioAsadoPorKilosElegidos + precioVacioPorKilosElegidos + precioMatambrePorKilosElegidos + precioChorizoPorKilosElegidos;
                        precioTotalDeLaCompra = precioTotalDeLaCompra + precioTotalDeLaCompra * 0.05;
                        dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                        MessageBox.Show($"COMPRA REALIZADA : el precio de su compra es {precioTotalDeLaCompra} su vuelto es {dineroDisponible} {mensaje}");
                    }
                    else
                    {
                        precioTotalDeLaCompra = precioAsadoPorKilosElegidos + precioVacioPorKilosElegidos + precioMatambrePorKilosElegidos + precioChorizoPorKilosElegidos;
                        dineroDisponible = dineroDisponible - precioTotalDeLaCompra;
                        MessageBox.Show($"COMPRA REALIZADA : el precio de su compra es {precioTotalDeLaCompra} su vuelto es {dineroDisponible} {mensaje}");

                    }
                }          
                else
                {
                    MessageBox.Show("Error, no tiene suficiente dinero para realizar la compra");
                }

          

               





            }

            this.labelDatos.Text = miHeladera.mostrarDetalleDeProductos();
            labelpPrecioDisponibleIngresado.Text = dineroDisponible.ToString();

        }



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
