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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            string usuario = textBox_Usuario.Text;
            string contrasenia = textBoxContrasena.Text;
            int tipoUsuario = comboBox1.SelectedIndex; // Obtener el índice del tipo de usuario seleccionado en el ComboBox
            string contrasenaVendedor = "1234";

            
            Usuario nuevoUsuario = null;
            if (tipoUsuario == 0)
            {
                nuevoUsuario = new Comprador(usuario, contrasenia,0);
                CrudUsuarios.Guardar(nuevoUsuario);
            }
            else if (tipoUsuario == 1)
            {
                //dialogo
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña de vendedor:", "Contraseña de Vendedor", "");

                // Verificar la contraseña ingresada
                if (input == contrasenaVendedor)
                {
                    nuevoUsuario = new Vendedor(usuario, contrasenia,1);
                    CrudUsuarios.Guardar(nuevoUsuario);
                }
                else
                {
                    MessageBox.Show("La contraseña de vendedor es incorrecta.", "Contraseña Incorrecta, USUARIO NO CREADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            
            

            MessageBox.Show("Usuario creado correctamente.");

            this.Close();
        }
    }
}
