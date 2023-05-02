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



        //genero constructor de lista de productos
        public Heladera(List<Producto> miListaDeProductosEnHeladera)
        {

            this.MiListaDeProductosEnHeladera = miListaDeProductosEnHeladera;
        }
        public List<Producto> MiListaDeProductosEnHeladera
        { 
            get => miListaDeProductosEnHeladera; set => miListaDeProductosEnHeladera = value; 
        }

        public void agregarPorCorte()
        {
            //foreach(Producto item in this.miListaDeProductosEnHeladera)
            //{
               
            //}
        }



        public void AgregarKilosPorCorteSeleccionado(int  indexCarne, float cantidadDeKilos)
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

        
        public static void agregarKilosPorCorteSeleccionado()
        {
        }




        public void cambiarPrecioDelCorte()
        {
        }


        //    //metodo para agregar un producto
        //    //metood para mostrar la lista con precios

    }
}
