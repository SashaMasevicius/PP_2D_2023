using Entidades;

namespace FrmCarniceria
{
    public partial class FrmIniciarSesion : Form
    {
        //lista de usuarios aprobados para iniciar sesion
        List<Usuario> miLista;
        Heladera miHeladera;
        List<Producto> listaProductos;

        private const string JsonFileName = "productos.json";
        private const string XmlFileName = "productos.xml";

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

            CargarProductosDesdeJson();
            CargarProductosDesdeXml();



            //string directoryPath = AppDomain.CurrentDomain.BaseDirectory; 
            //string jsonFilePath = Path.Combine(directoryPath, JsonFileName); 
            //string xmlFilePath = Path.Combine(directoryPath, XmlFileName); 
            //MessageBox.Show($"Ruta del archivo JSON: {jsonFilePath}\nRuta del archivo XML: {xmlFilePath}", "Rutas de archivos");

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
                        FrmCliente formularioComprador;
                        formularioComprador = new FrmCliente(((Comprador)item), miHeladera);
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

        /// <summary>
        /// cuando cierro app guardo en json y xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            GuardarProductosEnJson();
            GuardarProductosEnXml();
        }

        /// <summary>
        /// guardo en jsn
        /// </summary>
        private void GuardarProductosEnJson()
        {
            try
            {
                List<Producto> productos = CrudStock.Leer(); 
                string json = Serializar.SerializeToJson(productos);
                File.WriteAllText(JsonFileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los productos en formato JSON: " + ex.Message);
            }
        }
        /// <summary>
        /// cargo enjson
        /// </summary>
        private void CargarProductosDesdeJson()
        {
            try
            {
                if (File.Exists(JsonFileName))
                {
                    string json = File.ReadAllText(JsonFileName);
                    listaProductos = Serializar.DeserializeFromJson<List<Producto>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos desde el archivo JSON: " + ex.Message);
            }
        }
        /// <summary>
        /// guardo en xml
        /// </summary>
        private void GuardarProductosEnXml()
        {
            try
            {
                List<Producto> productos = CrudStock.Leer();
                Serializar.SerializeToXml(productos, XmlFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los productos en formato XML: " + ex.Message);
            }
        }
        /// <summary>
        /// cargo en xml
        /// </summary>
        private void CargarProductosDesdeXml()
        {
            try
            {
                if (File.Exists(XmlFileName))
                {
                    listaProductos = Serializar.DeserializeFromXml<List<Producto>>(XmlFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos desde el archivo XML: " + ex.Message);
            }
        }
    }
}