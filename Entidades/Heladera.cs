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


        public Heladera(List<Producto> miListaDeProductosEnHeladera)
        {

            this.MiListaDeProductosEnHeladera = miListaDeProductosEnHeladera;


        }
        //genero constructor de lista de productos



        public List<Producto> MiListaDeProductosEnHeladera
        {
            get => miListaDeProductosEnHeladera;
            set => miListaDeProductosEnHeladera = value;
        }



        /// <summary>
        /// MUESTRA DETALLES DE PRODUCTOS
        /// </summary>
        /// <returns></returns>
        public string mostrarDetalleDeProductos()
        {
            StringBuilder sb = new StringBuilder();

            int maxCorteLength = Math.Max("Corte".Length, MiListaDeProductosEnHeladera.Max(item => item.TipoCarne.ToString().Length));
            int maxPesoLength = "Peso".Length;
            int maxPrecioLength = "PrecioXkg".Length;

            string format = "{0,-" + (maxCorteLength + 20) + "} {1,-" + (maxPesoLength + 10) + "} {2,-" + (maxPrecioLength + 10) + "}";
            sb.AppendLine(string.Format(format, "Corte".PadRight(maxCorteLength), "Peso", "PrecioXkg"));

            foreach (Producto item in MiListaDeProductosEnHeladera)
            {
                string corte = item.TipoCarne.ToString().PadRight(maxCorteLength +20);
                string peso = item.Peso.ToString().PadRight(maxPesoLength + 10);
                string precio = item.PrecioPorKg.ToString().PadRight(maxPrecioLength + 10);

                sb.AppendLine(string.Format(format, corte, peso, precio));
            }

            return sb.ToString();
        }
        public string ObtenerTipoCarne()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                sb.AppendLine($"{item.TipoCarne}");
            }
            return sb.ToString();
        }


        /// <summary>
        /// obtengo precio
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double obtenerPrecio(int indice)
        {
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                if (this.MiListaDeProductosEnHeladera.IndexOf(item) == indice)
                   return item.PrecioPorKg;
            }
            return -1;         
        }

        public double obtenerKilos(int indice)
        {
            foreach (Producto item in this.MiListaDeProductosEnHeladera)
            {
                if (this.MiListaDeProductosEnHeladera.IndexOf(item) == indice)
                    return item.Peso;
            }
            return -1;
        }

        /// <summary>
        /// AGREGA KILOS AL ITEM ELEGIDO
        /// </summary>
        /// <param name="indexCarne"></param>
        /// <param name="cantidadDeKilos"></param>
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

       /// <summary>
       /// CAMBIA PRECIO DE CORTES
       /// </summary>
       /// <param name="indexCarne"></param>
       /// <param name="precioPorKilo"></param>
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

  



    }
}
