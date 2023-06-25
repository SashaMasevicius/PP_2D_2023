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
    public partial class FrmModificarCorte : Form
    {
        List<Producto> listaModificada;
        public FrmModificarCorte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            int nuevoPeso = 0;
            double nuevoPrecio = 0;

            //  nuevo peso
            if (int.TryParse(textBox2.Text, out nuevoPeso))
            {
                // Validar y obtener el nuevo precio
                if (double.TryParse(textBox1.Text, out nuevoPrecio))
                {
                    // Crear una instancia del objeto Producto con los valores modificados
                    


                    Producto productoModificado = new Producto(nuevoPeso, nuevoPrecio);
                    productoModificado.id = id;
                    listaModificada = new List<Producto>();
                    listaModificada.Add(productoModificado);
                    // Llamar al método Modificar para actualizar los datos en la base de datos
                    CrudStock.Modificar(productoModificado);
                    listaModificada = CrudStock.Leer();

                    // Mostrar un mensaje de éxito o realizar otras acciones necesarias
                    MessageBox.Show("El producto ha sido modificado correctamente.");
                   
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el precio.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el peso.");
            }
        }
    }
}
