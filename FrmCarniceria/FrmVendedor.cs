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
        Comprador comprador;
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
            this.dataGridView2.Visible = false;

            this.dataGridView2.ColumnCount = 5;




            MostrarStock();

        }


        /// <summary>
        /// muestro stock en dataGrridView
        /// </summary>

        public void MostrarStock()
        {

            List<Producto> miProducto = CrudStock.Leer();

            dataGridView1.Rows.Clear();

            foreach (Producto producto in miProducto)
            {
                dataGridView1.Rows.Add(producto.TipoCarne, producto.Peso, producto.PrecioPorKg);
            }



        }



        /// <summary>
        /// Agrega/restar kilos al corte seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int id = this.comboBoxNuevoCorte.SelectedIndex + 1;
            int cantidadKilosSeleccionado = (int)numericUpDownKilos.Value;
            Producto productoExistente = CrudStock.ObtenerProductoPorId(id);
            int PesoAnterior = productoExistente.Peso;
            if (radioButtonAgregarCarne.Checked == true)
            {


                int PesoTotal = PesoAnterior + cantidadKilosSeleccionado;
                double precioActual = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotal, precioActual);
                productoModificado.id = id;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }

            if (radioButtonQuitarCarne.Checked == true)
            {

                int PesoTotal = PesoAnterior - cantidadKilosSeleccionado;
                double precioActual = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotal, precioActual);
                productoModificado.id = id;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }






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

            int id = this.comboBoxCortePrecio.SelectedIndex + 1;
            double nuevoPrecioElegido;
            string precioValidador = this.textBoxPrecio.Text;
            bool boolNuevoPrecioNoString = double.TryParse(precioValidador, out nuevoPrecioElegido);


            if (boolNuevoPrecioNoString) // valido si no ess strring
            {
                if (nuevoPrecioElegido > 0)
                {

                    Producto productoExistente = CrudStock.ObtenerProductoPorId(id);
                    int PesoAnterior = productoExistente.Peso;

                    Producto productoModificado = new Producto(PesoAnterior, nuevoPrecioElegido);
                    productoModificado.id = id;
                    CrudStock.Modificar(productoModificado);

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




            if (kilosVendidos > Comprador.ObtenerPesoAsadoEnStock() || kilosVendidos > Comprador.ObtenerPesoVacioEnStock()
                || kilosVendidos > Comprador.ObtenerPesoMatambreEnStock() || kilosVendidos > Comprador.ObtenerPesoChorizoEnStock())
            {
                MessageBox.Show("ERROR. La cantidad que seleccionaste supera al stock");

            }
            else
            {
                this.dataGridView2.Visible = true;
                //creo una venta
                VentasHistorial ventasHist = new VentasHistorial(nombreComprador, nombreCorteCarne, kilosVendidos, precioVendido);
                //guardo venta
                CrudHistorialVentas.Guardar(ventasHist);
                RestarKilosALStock();
                ActualizarDataGridView();
                MostrarStock();
            }
                


                //crear archivo txt




        }


        private void RestarKilosALStock()
        {

            int indiceCorteCarne = this.comboBoxCortesVenta.SelectedIndex;
            int kilosVendidos = (int)this.numericUpDownKilosVenta.Value;

            if (indiceCorteCarne == 0)
            {

                Producto productoExistente = CrudStock.ObtenerProductoPorId(1);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosAsado = kilosVendidos;
                int PesoTotalA = PesoAnterior - cantidadKilosAsado;
                double precioActualA = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalA, precioActualA);
                productoModificado.id = 1;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }
            if (indiceCorteCarne == 1)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(2);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosVacio = kilosVendidos;
                int PesoTotalV = PesoAnterior - cantidadKilosVacio;
                double precioActualV = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalV, precioActualV);
                productoModificado.id = 2;
                CrudStock.Modificar(productoModificado);

                MostrarStock();
            }
            if (indiceCorteCarne == 2)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(3);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosMatambre = kilosVendidos;
                int PesoTotalM = PesoAnterior - cantidadKilosMatambre;
                double precioActualM = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalM, precioActualM);
                productoModificado.id = 3;
                CrudStock.Modificar(productoModificado);


                MostrarStock();
            }
            if (indiceCorteCarne == 3)
            {
                Producto productoExistente = CrudStock.ObtenerProductoPorId(4);
                int PesoAnterior = productoExistente.Peso;
                int cantidadKilosChorizo = kilosVendidos;
                int PesoTotalC = PesoAnterior - cantidadKilosChorizo;
                double precioActualC = productoExistente.PrecioPorKg;


                Producto productoModificado = new Producto(PesoTotalC, precioActualC);
                productoModificado.id = 4;
                CrudStock.Modificar(productoModificado);


                MostrarStock();
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

        /// <summary>
        /// cierro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetornarMenuPrincipal_Click(object sender, EventArgs e)
        {

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


        /// <summary>
        /// 
        /// IDventas a eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBorrar_Click(object sender, EventArgs e)
        {

            // interactua
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


        /// <summary>
        /// actualizo stock con boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActualizarStock_Click(object sender, EventArgs e)
        {

            MostrarStock();

        }




    }
}
