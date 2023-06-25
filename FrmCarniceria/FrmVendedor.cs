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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FrmCarniceria
{
    public partial class FrmVendedor : Form, iStockMensaje
    {
        Vendedor vendedor;
        Heladera miHeladera;
        List<VentasHistorial> listaVentas;
        List<Producto> miListaProductos;

        public FrmVendedor()
        {
            InitializeComponent();
        }
        public FrmVendedor(Vendedor miVendedor, Heladera miHeladera) : this()
        {
            this.vendedor = miVendedor;

            MessageBox.Show(miVendedor.crearMensajeBienvenido());


            this.miHeladera = miHeladera;



            //instancio y creo lista de clientes habituales a las cuales el vendedor puede acceder y vender

            miVendedor.AgregarClientesALista("Restaurante Madero");
            miVendedor.AgregarClientesALista("Restaurante Aleman");
            miVendedor.AgregarClientesALista("Restaurante Venezolano");




            // creo label con informacion
            //  this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();
            this.dataGridView2.Visible = false;

            this.dataGridView2.ColumnCount = 5;



            MostrarStock();

        }


        public void MostrarStock()
        {
            // Llamar al método mostrarDetalleDeProductos y obtener el resultado
            string detallesProductos = miHeladera.mostrarDetalleDeProductos();

            // Asignar el resultado al DataSource del ListBox
            listBox_Stock.DataSource = detallesProductos.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);



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
            MostrarStock();



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
                    MostrarStock();

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

            // Traigo Datos de los forms
            int indiceComprador = this.comboBoxRestaurante.SelectedIndex;
            string nombreComprador = comboBoxRestaurante.Text;
            string nombreCorteCarne = this.comboBoxCortesVenta.Text;
            int kilosVendidos = (int)this.numericUpDownKilosVenta.Value;
            int indiceCorteCarne = this.comboBoxCortesVenta.SelectedIndex;
            double precioVendido = (double)(miHeladera.obtenerPrecio(indiceCorteCarne) * kilosVendidos);

            if (this.vendedor.DisminuirKilosDelStock(miHeladera, indiceCorteCarne, kilosVendidos) != -1)
            {
                this.dataGridView2.Visible = true;

                //creo una venta
                VentasHistorial ventasHist = new VentasHistorial(nombreComprador, nombreCorteCarne, kilosVendidos, precioVendido);
                //guardo venta
                CrudHistorialVentas.Guardar(ventasHist);

                ActualizarDataGridView();
                MostrarStock();


                //crear archivo txt

            }
            else
            {
                MessageBox.Show("La cantidad de kilos excede la cantidad que hay en stock.");
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



        #region ocultar
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }



        private void textBoxAgregarCorte_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion



        /// <summary>
        /// 
        /// actualizar data grid view
        /// </summary>
        private void ActualizarDataGridView()
        {
            listaVentas = CrudHistorialVentas.Leer();

            // Limpiar el DataGridView
            dataGridView2.Rows.Clear();

            //ordeno por id
            listaVentas = listaVentas.OrderBy(venta => venta.Id).ToList();

            //recorro
            foreach (VentasHistorial venta in listaVentas)
            {
                dataGridView2.Rows.Add(venta.Id, venta.Comprador, venta.Corte, venta.Kilos, venta.TotalVenta);
            }
        }

        private void button_Leer_Click(object sender, EventArgs e)
        {


            this.dataGridView2.Visible = true;
            ActualizarDataGridView();
            MostrarStock();

        }

        //private void button_Modificar_Click(object sender, EventArgs e)
        //{

        //}

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

            // cuadro interactuar usuario
            string idString = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID Ventas a eliminar:", "Eliminar Venta");

            // id valido
            if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int id))
            {
                // si el ID existe
                bool ventaExistente = listaVentas.Any(venta => venta.Id == id);

                if (ventaExistente)
                {
                    // confirmacion
                    DialogResult result = MessageBox.Show("¿Estas seguro de que deseas eliminar esta venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // biorrar
                            CrudHistorialVentas.Borrar(id);

                            // actualizo la lista
                            listaVentas = CrudHistorialVentas.Leer();

                            ActualizarDataGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no corresponde a ninguna venta existente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para eliminar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmModificarCorte formulario = new FrmModificarCorte();
            formulario.ShowDialog();
        }

        private void buttonActualizarStock_Click(object sender, EventArgs e)
        {
                 


            //    miListaProductos = CrudStock.Leer();
            //Heladera miHeladera = new Heladera(listaProductos);


            //foreach (Producto item in miListaProductos)

            //    {
            //        listBox_Stock.Items.Add(item.ToString());
                    

            //    }

            
        }
    }
}
