namespace Entidades
{
    public class Comprador : Usuario
    {
       

        //Constructor

        public Comprador(string email, string contrasenia) : base(email, contrasenia)
        {

        }



        //Metodos

        /// <summary>
        /// Metodo que valida que el precio ingresado sea mayor o igual al minimo(1000) y que no sea un string 
        /// ni espacio vacio
        /// </summary>
        /// <param name="precioIngresado"></param> str para parsear valor desde un textbox
        /// <returns></returns>

        //metodo para establecer dinero maximo disponible
        public static double validarPrecioDisponible(string precioIngresado)
        {
            string precioValidador = precioIngresado;
            double nuevoPrecioElegido;
            bool boolNuevoPrecioNoString = double.TryParse(precioValidador, out nuevoPrecioElegido);

            if (boolNuevoPrecioNoString) // valido si no ess strring
            {
                if (nuevoPrecioElegido >= 1000)
                {
                    return nuevoPrecioElegido;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }

            return -1;
        }

  


        
        /// <summary>
        /// 
        /// obtiene el precio del precio por los kilos vendidos, tambien realiza una resta al item peso por los kilos vendidos del stock principal
        /// </summary>
        /// <param name="miHeladera"></param> obj mi heladera para recorrrer la lista
        /// <param name="kilosVendidos"></param> kilos que ingresa el usuarioi
        /// <param name="indexCarne"></param> indice del corte de carne
        /// <param name="indiceLista"></param> indice en la lista 
        /// <param name="precioCarne"></param> precio del corte
        /// <returns></returns>
        public double obtenerPrecioCortePorKilo(Heladera miHeladera, int kilosVendidos, int indexCarne ,int indiceLista, double precioCarne)
        {

            foreach (Producto item in miHeladera.MiListaDeProductosEnHeladera)
            {

                if (indexCarne == indiceLista && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == indiceLista)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                       
                        return precioCarne * kilosVendidos;
                        
                    }
                    else
                    {
                        return -1;

                    }
                }

            }
            return -1;

        }

        public void RestarKilosAlStock(Heladera miHeladera, int kilosVendidos, int indexCarne, int indiceLista, double precioCarne)
        {
            foreach (Producto item in miHeladera.MiListaDeProductosEnHeladera)
            {

                if (indexCarne == indiceLista && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == indiceLista)
                {
                    if (kilosVendidos <= item.Peso)
                    {
                        item.Peso -= kilosVendidos;
                       

                    }
                   
                }

            }
        }

    } //fin


}
