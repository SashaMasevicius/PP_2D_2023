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
                labelpPrecioDisponibleIngresado.Text = montoDisponibleStr + "$";
                validarPrecioParaComprar = true;

            }


        }

        // Boton para ingresar medio de pago y mostrar mensaje, el monto queda guardado en la pantalla para que sea visible al usuario
        private void buttonAgregarMedioDePago_Click(object sender, EventArgs e)
        {
            bool tarjeta = radioButtonTarjeta.Checked;
            bool efectivo = radioButtonEfectivo.Checked;


            if (Comprador.ObtenerFormaDePago(tarjeta, efectivo) == 1)
            {
                MessageBox.Show("El medio de pago elegido es: TARJETA");
                this.labelMedioDePago.Text = "TARJETA";
                validarMedioDePagoParaComprar = true;
            }
            else if (Comprador.ObtenerFormaDePago(tarjeta, efectivo) == 2)
            {
                MessageBox.Show("El medio de pago elegido es: EFECTIVO");
                this.labelMedioDePago.Text = "EFECTIVO";
                validarMedioDePagoParaComprar = true;
            }



        }

        //boton comprar
        private void button1_Click(object sender, EventArgs e)
        {
            //int cortesIndice = this.checkedListBoxCortes.SelectedIndex;

            //int kilosAsado = (int)this.numericUpDownKilosAsado.Value;
            //int kilosVacio = (int)this.numericUpDownKilosAsado.Value;
            //int kilosMatambre = (int)this.numericUpDownKilosAsado.Value;
            //int kilosChorizo = (int)this.numericUpDownKilosAsado.Value;

            //if (validarPrecioParaComprar == false && validarMedioDePagoParaComprar == false)
            //{
            //    MessageBox.Show("ERROR: Debe ingresar monto y medio de pago para poder realizar la compra");
            //}
            //else
            //{
            //    if (cortesIndice == 0) // asado
            //    {
            //        kilosAsado;
            //    }
            //    if (cortesIndice == 1) // asado
            //    {
            //        kilosVacio;
            //    }
            //    if ((cortesIndice) == 2) // asado
            //    {
            //        kilosMatambre;
            //    }
            //    if ((cortesIndice) == 3) // asado
            //    {
            //        kilosChorizo;
            //    }
            //}

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


    }
}
