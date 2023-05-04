using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Heladera
    {
        //atributos
        List<Producto> miListaDeProductosEnHeladera;
        List<Comprador> miListaDeClientesFijos;

        public Heladera(List<Producto> miListaDeProductosEnHeladera)
        {

            this.MiListaDeProductosEnHeladera = miListaDeProductosEnHeladera;
            

        }
        //genero constructor de lista de productos
        public Heladera(List<Producto> miListaDeProductosEnHeladera, List<Comprador> miListaDeClientesFijos)
        {

            this.MiListaDeProductosEnHeladera = miListaDeProductosEnHeladera;
            this.MiListaDeClientesFijos = miListaDeClientesFijos;

        }


        public List<Producto> MiListaDeProductosEnHeladera
        { 
            get => miListaDeProductosEnHeladera; set => miListaDeProductosEnHeladera = value; 
        }
        public List<Comprador> MiListaDeClientesFijos { get => miListaDeClientesFijos; set => miListaDeClientesFijos = value; }

        public void agregarPorCorte()
        {
            //foreach(Producto item in this.miListaDeProductosEnHeladera)
            //{
               
            //}
        }


        public string mostrarDetalleDeProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Corte    Kilos    Precio");
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                sb.AppendLine($"{item.TipoCarne}        {item.Peso}        {item.PrecioPorKg}");
            }
            return sb.ToString();
        }


        public void AgregarKilosPorCorteSeleccionado(int  indexCarne, int cantidadDeKilos)
        {

            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                // si elige el indice de este corte && la lista esta en la posicion del primer corte 
                if (indexCarne == (int)eCarne.Asado && this.MiListaDeProductosEnHeladera.IndexOf(item) == 0)
                {
                    item.Peso += cantidadDeKilos;
                   
                    break;
                }
                else if (indexCarne == (int)eCarne.Vacio && this.MiListaDeProductosEnHeladera.IndexOf(item) == 1)
                {
                    item.Peso += cantidadDeKilos;
                    break;
                }
                else if(indexCarne == (int)eCarne.Matambre && this.MiListaDeProductosEnHeladera.IndexOf(item) == 2)
                {
                    item.Peso += cantidadDeKilos;
                    break;
                }
                else if (indexCarne == (int)eCarne.Chorizo && this.MiListaDeProductosEnHeladera.IndexOf(item) == 3)
                {
                    item.Peso += cantidadDeKilos;
                    break;
                }

            }

        }

       
        public void cambiarPrecioDelCorte(int indexCarne, double precioPorKilo)
        {
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                
                if (indexCarne == (int)eCarne.Asado && this.MiListaDeProductosEnHeladera.IndexOf(item) == 0)
                {
                    item.PrecioPorKg = precioPorKilo;

                    break;
                }
                else if (indexCarne == (int)eCarne.Vacio && this.MiListaDeProductosEnHeladera.IndexOf(item) == 1)
                {
                    item.PrecioPorKg = precioPorKilo;
                    break;
                }
                else if (indexCarne == (int)eCarne.Matambre && this.MiListaDeProductosEnHeladera.IndexOf(item) == 2)
                {
                    item.PrecioPorKg = precioPorKilo;
                    break;
                }
                else if (indexCarne == (int)eCarne.Chorizo && this.MiListaDeProductosEnHeladera.IndexOf(item) == 3)
                {
                    item.PrecioPorKg = precioPorKilo;
                    break;
                }

            }

        }


        public string recorrerVendedoresSelecionadosYGuardarMensaje( int indiceCompradorFijo,int indexCarneCombo, int kilosVendidos)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Comprador item in this.MiListaDeClientesFijos)
            {
                if(indiceCompradorFijo == 0 && this.MiListaDeClientesFijos.IndexOf(item) ==0)
                {
                    //sb.AppendLine($"Destino: Restaurante Madero");
                    sb.AppendLine(venderProductosAClientesSeleccionados(indexCarneCombo, kilosVendidos));
                    break;
                }
                else if (indiceCompradorFijo == 1 && this.MiListaDeClientesFijos.IndexOf(item) == 1)
                {
                    sb.AppendLine($"Destino: Restaurante Aleman");
                    sb.AppendLine(venderProductosAClientesSeleccionados(indexCarneCombo, kilosVendidos));
                    break;
                    
                }
                else if (indiceCompradorFijo == 2 && this.MiListaDeClientesFijos.IndexOf(item) == 2)
                {
                    sb.AppendLine($"Destino: Restaurante Venezolano");
                    sb.AppendLine(venderProductosAClientesSeleccionados(indexCarneCombo, kilosVendidos));
                    break;
                    
                }
            }
            return sb.ToString();
        }

        public string venderProductosAClientesSeleccionados(int indexCarneCombo,  int kilosVendidos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {

                if (indexCarneCombo == (int)eCarne.Asado && this.MiListaDeProductosEnHeladera.IndexOf(item) == 0)
                {
                    if(kilosVendidos <=item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        sb.AppendLine($"Producto: Carne");
                        sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
                        sb.AppendLine($"Stock disponible: {item.Peso}kg");
                        break;
                    }
                    else
                    {
                        sb.AppendLine("Error, estas intentando vender mas kg del stock disponible ");
                        sb.AppendLine("Venta no realizada");
                        break;
                    }
                                     
                }
                else if (indexCarneCombo == (int)eCarne.Vacio && this.MiListaDeProductosEnHeladera.IndexOf(item) == 1)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        sb.AppendLine($"Producto: Vacio");
                        sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
                        sb.AppendLine($"Stock disponible: {item.Peso}kg");
                        break;
                    }
                    else
                    {
                        sb.AppendLine("Error, estas intentando vender mas kg del stock disponible");
                        sb.AppendLine("Venta no realizada");
                        break;
                    }
                }
                else if (indexCarneCombo == (int)eCarne.Matambre && this.MiListaDeProductosEnHeladera.IndexOf(item) == 2)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        sb.AppendLine($"Producto: Matambre");
                        sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
                        sb.AppendLine($"Stock disponible: {item.Peso}kg");
                        break;
                    }
                    else
                    {
                        sb.AppendLine("Error, estas intentando vender mas kg del stock disponible");
                        sb.AppendLine("Venta no realizada");
                        break;
                    }
                }
                else if (indexCarneCombo == (int)eCarne.Chorizo && this.MiListaDeProductosEnHeladera.IndexOf(item) == 3)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                        sb.AppendLine($"Producto: Chorizo");
                        sb.AppendLine($"Kilos vendidos: {kilosVendidos}kg");
                        sb.AppendLine($"Stock disponible: {item.Peso}kg");
                        break;
                    }
                    else
                    {
                        sb.AppendLine("Error, estas intentando vender mas kg del stock disponible");
                        sb.AppendLine("Venta no realizada");
                        break;
                    }
                }

            }

            return sb.ToString();
        }



    }
}
