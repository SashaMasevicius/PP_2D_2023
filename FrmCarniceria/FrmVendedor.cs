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
        Vendedor vendedor;
        Heladera miHeladera;

        public FrmVendedor()
        {
            InitializeComponent();
        }
        public FrmVendedor(Vendedor miVendedor) : this()
        {
            this.vendedor = miVendedor;
            MessageBox.Show($"Bienvenido {this.vendedor.Email}");




            //harcodeo productos para agregar a la heladera

            Producto prodUno = new Producto(eCarne.Asado, 20, 2000);
            Producto prodDos = new Producto(eCarne.Vacio, 15, 2200);
            Producto prodTres = new Producto(eCarne.Matambre, 10, 2500);
            Producto prodCuatro = new Producto(eCarne.Chorizo, 0, 1500);


            //creo una lista del tipo producto

           listaDeProductos = new List<Producto>();
            listaDeProductos.Add(prodUno);
            listaDeProductos.Add(prodDos);
            listaDeProductos.Add(prodTres);
            listaDeProductos.Add(prodCuatro);

            //instancio y creo lista de clientes habituales a las cuales el vendedor puede acceder y vender
            // CAMBIAR ESTO??
            Comprador miCompradorFijoUno = new Comprador("restauranteMadero@gmail.com", "1234", "Restaurante Madero");
            Comprador miCompradorFijoDos = new Comprador("restauranteAleman@gmail.com", "AAAA", "Restaurante Aleman");
            Comprador miCompradorFijoTres = new Comprador("restauranteVenezolano@gmail.com", "ABCD", "Restaurante Venezolano");


            //instancio el objeto heladera

            miHeladera = new Heladera(listaDeProductos);


            // creo label con informacion
           this.labelDetalles.Text = miHeladera.mostrarDetalleDeProductos();

        }
        private void textBoxAgregarCorte_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {


            int indexCorte = this.comboBoxNuevoCorte.SelectedIndex;
            int cantidadKilosSeleccionado = (int)numericUpDownKilos.Value;

            miHeladera.AgregarKilosPorCorteSeleccionado(indexCorte, cantidadKilosSeleccionado);


            foreach (Producto item in miHeladera.MiListaDeProductosEnHeladera)
            {
                MessageBox.Show($" {item.TipoCarne} {item.Peso} {item.PrecioPorKg}");
            }

                //this.labelDetalles.Text = mostrarDetalleDeProductos();

        }

             

        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(Heladera.mostrarDetalleDeProductos());
            //MessageBox.Show(mostrarDetalleDeProductos());

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nuevoPrecioElegido = double.Parse(this.textBoxPrecio.Text);
            int indiceCorteCarne = this.comboBoxCortePrecio.SelectedIndex;

    

     
       

           /// this.labelDetalles.Text = mostrarDetalleDeProductos();


        }

  
        private void buttonVenderListaDeClientes_Click(object sender, EventArgs e)
        {
            //int indiceRestaurante = this.comboBoxRestaurante.SelectedIndex;
            //int indiceCorteCarne = this.comboBoxCortesVenta.SelectedIndex;
            //int kilosElegidos = (int)this.numericUpDownKilosVenta.Value;
            //double precioDeVenta;

            //switch (indiceRestaurante)
            //{
            //    case 0:
            //        switch (indiceCorteCarne)
            //        {
            //            case 0:
            //                miAcumuladorDeKilos.AcumuladorKilosAsado = miAcumuladorDeKilos.AcumuladorKilosAsado - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioAsado;
            //                MessageBox.Show($"Vendiste {kilosElegidos} kilos de asado al Restaurante Madero, precio de venta : {precioDeVenta}");
            //                break;
            //            case 1:
            //                miAcumuladorDeKilos.AcumuladorKilosVacio = miAcumuladorDeKilos.AcumuladorKilosVacio - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioVacio;
            //                break;
            //            case 2:
            //                miAcumuladorDeKilos.AcumuladorKilosMatambre = miAcumuladorDeKilos.AcumuladorKilosMatambre - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioMatambre;
            //                break;
            //            case 3:
            //                miAcumuladorDeKilos.AcumuladorKilosChorizo = miAcumuladorDeKilos.AcumuladorKilosChorizo - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioChorizo;
            //                break;
            //        }
            //        break;
            //    case 1:
            //        switch (indiceCorteCarne)
            //        {
            //            case 0:
            //                miAcumuladorDeKilos.AcumuladorKilosAsado = miAcumuladorDeKilos.AcumuladorKilosAsado - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioAsado;

            //                break;
            //            case 1:
            //                miAcumuladorDeKilos.AcumuladorKilosVacio = miAcumuladorDeKilos.AcumuladorKilosVacio - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioVacio;
            //                break;
            //            case 2:
            //                miAcumuladorDeKilos.AcumuladorKilosMatambre = miAcumuladorDeKilos.AcumuladorKilosMatambre - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioMatambre;
            //                break;
            //            case 3:
            //                miAcumuladorDeKilos.AcumuladorKilosChorizo = miAcumuladorDeKilos.AcumuladorKilosChorizo - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioChorizo;

            //                break;
            //        }
            //        break;
            //    case 2:
            //        switch (indiceCorteCarne)
            //        {
            //            case 0:
            //                miAcumuladorDeKilos.AcumuladorKilosAsado = miAcumuladorDeKilos.AcumuladorKilosAsado - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioAsado;
            //                break;
            //            case 1:
            //                miAcumuladorDeKilos.AcumuladorKilosVacio = miAcumuladorDeKilos.AcumuladorKilosVacio - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioVacio;
            //                break;
            //            case 2:
            //                miAcumuladorDeKilos.AcumuladorKilosMatambre = miAcumuladorDeKilos.AcumuladorKilosMatambre - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioMatambre;
            //                break;
            //            case 3:
            //                miAcumuladorDeKilos.AcumuladorKilosChorizo = miAcumuladorDeKilos.AcumuladorKilosChorizo - kilosElegidos;
            //                precioDeVenta = kilosElegidos * miNuevoPrecio.NuevoPrecioChorizo;
            //                break;
            //        }
            //        break;
            //}
            //this.labelDetalles.Text = mostrarDetalleDeProductos();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
