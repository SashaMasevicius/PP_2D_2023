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
        List<Producto> listaDeProductos;
        List<string> verDetallesDeVentas;
        
        Vendedor vendedor;
        Heladera miHeladera;
        string msj;

        public FrmVendedor()
        {
            InitializeComponent();
        }
        public FrmVendedor(Vendedor miVendedor) : this()
        {
            this.vendedor = miVendedor;
            MessageBox.Show($"Bienvenido {this.vendedor.Email}");
            



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

            //instancio y creo lista de clientes habituales a las cuales el vendedor puede acceder y vender
         
            miVendedor.AgregarClientesALista("Restaurante Madero");
            miVendedor.AgregarClientesALista("Restaurante Aleman");
            miVendedor.AgregarClientesALista("Restaurante Venezolano");
           

            //Comprador miCompradorFijoDos = new Comprador("restauranteAleman@gmail.com", "AAAA", "Restaurante Aleman");
            //Comprador miCompradorFijoTres = new Comprador("restauranteVenezolano@gmail.com", "ABCD", "Restaurante Venezolano");

            //miListaDeCompradoresFijos = new List<Comprador>();
            //miListaDeCompradoresFijos.Add(miCompradorFijoUno);
            //miListaDeCompradoresFijos.Add(miCompradorFijoDos);
            //miListaDeCompradoresFijos.Add(miCompradorFijoTres);


            //instancio el objeto heladera

            miHeladera = new Heladera(listaDeProductos);


            // creo label con informacion
            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();

        }
        private void textBoxAgregarCorte_TextChanged(object sender, EventArgs e)
        {

        }


        //boton agregar kg
        private void button1_Click(object sender, EventArgs e)
        {


            int indexCorte = this.comboBoxNuevoCorte.SelectedIndex;
            int cantidadKilosSeleccionado = (int)numericUpDownKilos.Value;
            miHeladera.AgregarKilosPorCorteSeleccionado(indexCorte, cantidadKilosSeleccionado);
            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();

        }



        private void button3_Click(object sender, EventArgs e)
        {
           foreach(string item in verDetallesDeVentas)
            {
                MessageBox.Show(item);
            }

        }


        // bootton cambiar precio
        private void button2_Click(object sender, EventArgs e)
        {
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


        private void buttonVenderListaDeClientes_Click(object sender, EventArgs e)
        {
            int indiceComprador = this.comboBoxRestaurante.SelectedIndex;
            int indiceCorteCarne = this.comboBoxCortesVenta.SelectedIndex;
            int kilosVendidos = (int)this.numericUpDownKilosVenta.Value;



            MessageBox.Show(this.vendedor.ObtenerMensajeDelNombreDelComprador(this.vendedor, miHeladera, indiceComprador) + this.vendedor.RetornarMensajeCliente(miHeladera, indiceCorteCarne, kilosVendidos));



            this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
