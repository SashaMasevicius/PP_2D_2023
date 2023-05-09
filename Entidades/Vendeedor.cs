using System.Text;

namespace Entidades
{
    public class Vendedor : Usuario
    {
         List<string> listaDeClientesFijos;

        

        //creo vendedor de tipo usuario
        public Vendedor(string email, string contrasenia) : base(email, contrasenia)
        {
            this.ListaDeClientesFijos = new List<string>();
        }



        public List<string> ListaDeClientesFijos
        { 
            get => listaDeClientesFijos; 
            set => listaDeClientesFijos = value;
        }

        /// <summary>
        /// mensaje que muestra email cuando inicia sesion
        /// </summary>
        /// <returns></returns>
        public override string crearMensajeBienvenido()
        {
            return $"el usuario {this.Email} ha iniciado sesión como vendedor";
        }


        /// <summary>
        /// agrega cliente a la lista de clientes
        /// </summary>
        /// <param name="miCliente"></param>
        public void AgregarClientesALista(string miCliente)
        {
            if (miCliente != null)
            {
                this.ListaDeClientesFijos.Add(miCliente);
            }

        }

        /// <summary>
        /// Disminuye el stock en kilos dependiendo la compra del cliente
        /// </summary>
        /// <param name="miHeladera"></param>
        /// <param name="indexCarne"></param>
        /// <param name="kilosVendidos"></param>
        /// <returns></returns>
        public int DisminuirKilosDelStock(Heladera miHeladera, int indexCarne, int kilosVendidos)
        {
           

            foreach (Producto item in miHeladera.MiListaDeProductosEnHeladera)
            {

                if (indexCarne == (int)eCarne.Asado && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == 0)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        return 0;
                    }
                    else
                    {

                        return -1;
                    }
                }
                else if (indexCarne == (int)eCarne.Vacio && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == 1)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        return 1;
                    }
                    else
                    {

                        return -1;
                    }
                }
                else if (indexCarne == (int)eCarne.Matambre && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == 2)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        return 2;
                    }
                    else
                    {

                        return -1;
                    }
                }
                else if (indexCarne == (int)eCarne.Chorizo && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == 3)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        return 3;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            return -1;
        }

        /// <summary>
        /// segun el indice retorna los kilos vendidos
        /// </summary>
        /// <param name="miHeladera"></param>
        /// <param name="indexCarne"></param> indice del corte de carne
        /// <param name="kilosVendidos"></param> cantida de kiulos vendidos
        /// <returns></returns> retorna mensaje con tipo de carne y kilos
        public string RetornarMensajeCliente(Heladera miHeladera, int indexCarne, int kilosVendidos)
        {
           // int indiceElegidoPorCliente = VenderProductoACliente(miHeladera, indexCarne, kilosVendidos);
            StringBuilder sb = new StringBuilder();
            if(indexCarne == 0)
            {
                
                sb.AppendLine($"{kilosVendidos}kg");
            }
            else if(indexCarne == 1)
            {
               
                sb.AppendLine($"{kilosVendidos}kg");
            }
            else if(indexCarne == 2)
            {
  
                sb.AppendLine($"{kilosVendidos}kg");
            }
            else if(indexCarne == 3)
            {
               
                sb.AppendLine($"{kilosVendidos}kg");
            }

            return sb.ToString();
        }

        /// <summary>
        /// devuelve el nombre del corte de carne segun el indice 
        /// </summary>
        /// <param name="indiceElegido"></param> indice para obtener nombre
        /// <returns></returns>
        public string RetornarNombreDeCorteElegidoAlVender(int indiceElegido)
        {
            StringBuilder sb = new StringBuilder();

            if (indiceElegido == 0)
            {
                sb.AppendLine($"Asado");
                
            }
            else if (indiceElegido == 1)
            {
                sb.AppendLine($"Vacio");
               
            }
            else if (indiceElegido == 2)
            {
                sb.AppendLine($"Matambre");
              
            }
            else if (indiceElegido == 3)
            {
                sb.AppendLine($"Chorizo");
            
            }
            return sb.ToString();
        }
        /// <summary>
        /// retorna  del nombre del comprador
        /// </summary>
        /// <param name="miVendedor"></param> para recorrer lista de clientes en mi vendedor
        /// <param name="indiceCompradorFijo"></param>
        /// <returns></returns>
        public string RetornarNombreDelComprador(Vendedor miVendedor,int indiceCompradorFijo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String item in miVendedor.ListaDeClientesFijos)
            {
                if (indiceCompradorFijo == 0 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 0)
                {
                    sb.AppendLine($"Restaurante Madero");
                    break;
                }
                else if (indiceCompradorFijo == 1 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 1)
                {
                    sb.AppendLine($"Restaurante Aleman");
                    break;

                }
                else if (indiceCompradorFijo == 2 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 2)
                {
                    sb.AppendLine($"Restaurante Venezolano");
                    break;

                }
               
            }
            return sb.ToString();
            
        }

        

     
    }
}
