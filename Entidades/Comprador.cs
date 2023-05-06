namespace Entidades
{
    public class Comprador : Usuario
    {
        //Atributos

        float dineroMaximoDisponible;
        string nombreComprador;


        //Constructor

        public Comprador(string email, string contrasenia) : base(email, contrasenia)
        {

        }
        //Genero constructor para clientes, la cual el vendedor podra acceder, ver su nombre y realizarle ventas
        public Comprador(string email, string contrasenia, string nombreComprador) : base(email, contrasenia)
        {

        }

        public float DineroMaximoDisponible
        {
            get => dineroMaximoDisponible;
            set => dineroMaximoDisponible = value;
        }
        public string NombreComprador { get => nombreComprador; set => nombreComprador = value; }



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

        public static int ObtenerFormaDePago(bool tarjeta, bool efectivo)
        {
            if (tarjeta == true)
            {
                return 1;
            }
            if (efectivo == true)
            {
                return 2;
            }
            return -1;
        }

        public double obte(Heladera miHeladera, int kilosVendidos, int indexCarne,double montoDisponible, int indiceLista,double precioCarne)
        {

                foreach (Producto item in miHeladera.MiListaDeProductosEnHeladera)
                {

                    if (indexCarne == indiceLista && miHeladera.MiListaDeProductosEnHeladera.IndexOf(item) == indiceLista)
                    {
                        if (kilosVendidos <= item.Peso)
                        {
                            item.Peso -= kilosVendidos;
                            montoDisponible =  montoDisponible - (precioCarne * kilosVendidos);
                             return montoDisponible;
                        }
                        else
                        {
                        return -1;
                            
                        }
                    }

                }
            return -1;
            
        }
          


    } //fin


}
