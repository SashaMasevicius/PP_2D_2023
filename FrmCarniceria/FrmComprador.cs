using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCarniceria
{
    public partial class FrmComprador : Form
    {
        Comprador miComprador;
        Heladera miHeladera;

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
        /// Boton para obtener valor del dinero que ingresa el usuario para realizar compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptarDineroDisponible_Click(object sender, EventArgs e)
        {
            string montoDisponibleStr = textBoxDineroDisponible.Text;

            if (Comprador.validarPrecioDisponible(montoDisponibleStr) == -1)
            {
                MessageBox.Show("Error, el numero ingresado no es valido");
            }
            else
            {
                double montoDisponible = Comprador.validarPrecioDisponible(montoDisponibleStr);
                MessageBox.Show($"Tu dinero disponible es : {montoDisponible}");
            }


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
    }
}
