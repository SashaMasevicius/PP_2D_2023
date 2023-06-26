using Entidades;

namespace FrmCarniceria
{
    public partial class FrmIniciarSesion : Form
    {
        //lista de usuarios aprobados para iniciar sesion
        List<Usuario> miLista;
        Heladera miHeladera;
        List<Producto> listaProductos;
        //const
        public FrmIniciarSesion()
        {


            InitializeComponent();




            //Producto prodUno = new Producto(eCarne.Asado, 1000, 2000);
            //Producto prodDos = new Producto(eCarne.Vacio, 1500, 2200);
            //Producto prodTres = new Producto(eCarne.Matambre, 1200, 2500);
            //Producto prodCuatro = new Producto(eCarne.Chorizo, 800, 1500);



            ////creo una lista del tipo producto
            //List<Producto> listaDeProducto;
            //listaDeProducto = new List<Producto>();
            //listaDeProducto.Add(prodUno);
            //listaDeProducto.Add(prodDos);
            //listaDeProducto.Add(prodTres);
            //listaDeProducto.Add(prodCuatro);
            //CrudStock.Guardar(prodUno);
            //CrudStock.Guardar(prodDos);
            //CrudStock.Guardar(prodTres);
            //CrudStock.Guardar(prodCuatro);


            //miHeladera = new Heladera(listaDeProducto);

            //instancio y agrego los usuarios a la lista.
            listaProductos = CrudStock.Leer();

            miLista = CrudUsuarios.Leer();

            miHeladera = new Heladera(listaProductos);
            // CrudUsuarios.Guardar();



        }


        /// <summary>
        /// El evento que se desencadena al hacer click en el boton iniciar sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/sasha/OneDrive/Escritorio/BotonSound.wav";
            player.Play();


            // guardo los valores de los textbox
            string mail = this.textBoxEmail.Text;
            string contrasena = this.textBoxContrasena.Text;

            bool comprobar = false;


            //recorro
            foreach (Usuario item in miLista)
            {
                if (item.Email == mail && item.Contrasenia == contrasena)
                {
                    if (item is Comprador)
                    {
                        FrmComprador formularioComprador;
                        formularioComprador = new FrmComprador(((Comprador)item), miHeladera);
                        formularioComprador.Show();
                        //this.Hide();
                        comprobar = true;
                        this.textBoxEmail.Text = "";
                        this.textBoxContrasena.Text = "";
                        break;
                    }
                    else if (item is Vendedor)
                    {
                        FrmVendedor formularioVendedor;
                        formularioVendedor = new FrmVendedor(((Vendedor)item), miHeladera);
                        formularioVendedor.Show();
                        // this.Hide();
                        comprobar = true;
                        this.textBoxEmail.Text = "";
                        this.textBoxContrasena.Text = "";
                        break;
                    }
                }
            }

            if (comprobar is false)
            {
                MessageBox.Show("Usuario y contraseña incorrecta");
                this.textBoxEmail.Text = "";
                this.textBoxContrasena.Text = "";
            }



        }

        /// <summary>
        /// este boton harcodea un usuario valido del tipo comprador en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {


            Comprador compradorInvitado = new Comprador("invitado@comprador.com", "comprador");
            miLista.Add(compradorInvitado);

            this.textBoxEmail.Text = compradorInvitado.Email;
            this.textBoxContrasena.Text = compradorInvitado.Contrasenia;

        }

        /// <summary>
        /// este boton harcodea un usuario valido del tipo vendedor en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonCompletarVendedor_Click(object sender, EventArgs e)
        {

            Vendedor vendedorInvitado = new Vendedor("invitado@vendedor.com", "vendedor");
            miLista.Add(vendedorInvitado);

            this.textBoxEmail.Text = vendedorInvitado.Email;
            this.textBoxContrasena.Text = vendedorInvitado.Contrasenia;

        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.ShowDialog();

            // actuualizo la lista de usuarios después de cerrar la ventana emergente
            miLista = CrudUsuarios.Leer();
        }
    }
}