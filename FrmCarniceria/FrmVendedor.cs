using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace FrmCarniceria
{
    public partial class FrmVendedor : Form
    {
        
        

        Vendedor vendedor;
        Heladera miHeladera ;


        public FrmVendedor()
        {
            InitializeComponent();
        }
        public FrmVendedor(Vendedor miVendedor,Heladera miHeladera) : this()
        {
            this.vendedor = miVendedor;

            MessageBox.Show(miVendedor.crearMensajeBienvenido());


            this.miHeladera = miHeladera;



            //instancio y creo lista de clientes habituales a las cuales el vendedor puede acceder y vender

            miVendedor.AgregarClientesALista("Restaurante Madero");
            miVendedor.AgregarClientesALista("Restaurante Aleman");
            miVendedor.AgregarClientesALista("Restaurante Venezolano");




            // creo label con informacion
            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();
            this.dataGridView2.Visible = false;

            this.dataGridView2.ColumnCount = 4;
        }
        private void textBoxAgregarCorte_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Agrega kilos al corte seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            int indexCorte = this.comboBoxNuevoCorte.SelectedIndex;
            int cantidadKilosSeleccionado = (int)numericUpDownKilos.Value;
            miHeladera.AgregarKilosPorCorteSeleccionado(indexCorte, cantidadKilosSeleccionado);
            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();

        }






        /// <summary>
        /// 
        /// Este boton cambia/actualiza el precio del cortte seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();

            string precioValidador = this.textBoxPrecio.Text;
            double nuevoPrecioElegido;
            bool boolNuevoPrecioNoString = double.TryParse(precioValidador, out nuevoPrecioElegido);
            int indiceCorteCarne = this.comboBoxCortePrecio.SelectedIndex;

            if (boolNuevoPrecioNoString) // valido si no ess strring
            {
                if (nuevoPrecioElegido > 0)
                {
                    miHeladera.cambiarPrecioDelCorte(indiceCorteCarne, nuevoPrecioElegido);
                }
                else
                {
                    MessageBox.Show("El numero es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("No ingresaste ningun numero");
            }
            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();
        }

        /// <summary>
        /// Este boton es para realizar ventas a clientes fijos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVenderListaDeClientes_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();


            int indiceComprador = this.comboBoxRestaurante.SelectedIndex;
            int indiceCorteCarne = this.comboBoxCortesVenta.SelectedIndex;
            int kilosVendidos = (int)this.numericUpDownKilosVenta.Value;
            string nombreComprador = this.vendedor.RetornarNombreDelComprador(this.vendedor, indiceComprador);
            string nombreCorteCarne = vendedor.RetornarNombreDeCorteElegidoAlVender(indiceCorteCarne);
            string nombreKilosVendidos = this.vendedor.RetornarMensajeCliente(miHeladera, indiceCorteCarne, kilosVendidos);
            double precioVendido = miHeladera.obtenerPrecio(indiceCorteCarne) * kilosVendidos;



            if (this.vendedor.DisminuirKilosDelStock(miHeladera, indiceCorteCarne, kilosVendidos) != -1)
            {
                this.dataGridView2.Visible = true;
                //agregar renglon data 

                int nuevoRenglon = dataGridView2.Rows.Add();


                dataGridView2.Rows[nuevoRenglon].Cells[0].Value = nombreComprador;
                dataGridView2.Rows[nuevoRenglon].Cells[1].Value = nombreCorteCarne;
                dataGridView2.Rows[nuevoRenglon].Cells[2].Value = nombreKilosVendidos;
                dataGridView2.Rows[nuevoRenglon].Cells[3].Value = precioVendido;

                this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();

            }
            else
            {
                MessageBox.Show("La cantidad de kilos excede la cantidad que hay stock, vuelva a intentar con stock disponible o elija otro producto");
            }


        }

        /// <summary>
        /// autocompleta campos para prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAutocompletar_Click(object sender, EventArgs e)
        {
            comboBoxNuevoCorte.SelectedIndex = 1;
            numericUpDownKilos.Value = 5;
            comboBoxCortePrecio.SelectedIndex = 2;
            textBoxPrecio.Text = "1200";
            comboBoxRestaurante.SelectedIndex = 1;
            comboBoxCortesVenta.SelectedIndex = 1;
            numericUpDownKilosVenta.Value = 5;
        }

        private void buttonRetornarMenuPrincipal_Click(object sender, EventArgs e)
        {
            //FrmIniciarSesion formularioIniciarSesion;
            //formularioIniciarSesion = new FrmIniciarSesion();
            //formularioIniciarSesion.Show();
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

    }
}
