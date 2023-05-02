using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        //metodo para establecer dinero maximo disponible


    }
}
