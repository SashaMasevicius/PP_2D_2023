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

        public void AgregarClientesALista(string miCliente)
        {
            if (miCliente != null)
            {
                this.ListaDeClientesFijos.Add(miCliente);
            }


        }

        public List<string> ListaDeClientesFijos { get => listaDeClientesFijos; set => listaDeClientesFijos = value; }

        public int VenderProductoACliente(Heladera miHeladera, int indexCarne, int kilosVendidos)
        {
            StringBuilder sb = new StringBuilder();

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

        public string RetornarMensajeCliente(Heladera miHeladera, int indexCarne, int kilosVendidos)
        {
            int indiceElegidoPorCliente = VenderProductoACliente(miHeladera, indexCarne, kilosVendidos);
            StringBuilder sb = new StringBuilder();
            if(indiceElegidoPorCliente ==0)
            {
                 sb.AppendLine($"Producto: Asado");
                sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
            }
            else if(indiceElegidoPorCliente ==1)
            {
                sb.AppendLine($"Producto: Vacio");
                sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
            }
            else if(indiceElegidoPorCliente ==2)
            {
                sb.AppendLine($"Producto: Matambre");
                sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
            }
            else if(indiceElegidoPorCliente ==3)
            {
                sb.AppendLine($"Producto: Chorizo");
                sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
            }
            else if(indiceElegidoPorCliente ==-1)
            {
                sb.AppendLine("La cantidad de kilos excede la cantidad que hay stock, vuelva a intentar con stock dispoible o elija otro producto");
            }
            return sb.ToString();
        }

        public string ObtenerMensajeDelNombreDelComprador(Vendedor miVendedor, Heladera miHeladera, int indiceCompradorFijo, int indexCarneCombo, int kilosVendidos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String item in miVendedor.ListaDeClientesFijos)
            {
                if (indiceCompradorFijo == 0 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 0)
                {
                    sb.AppendLine($"Destino: Restaurante Venezolano");
                    break;
                }
                else if (indiceCompradorFijo == 1 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 1)
                {
                    sb.AppendLine($"Destino: Restaurante Venezolano");
                    break;

                }
                else if (indiceCompradorFijo == 2 && miVendedor.ListaDeClientesFijos.IndexOf(item) == 2)
                {
                    sb.AppendLine($"Destino: Restaurante Venezolano");
                    break;

                }
               
            }
            return sb.ToString();
            
        }

     
    }
}
