using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Persona
    {
        List<string>ListaCortes = new List<string>();
        float[] precioPorKilo = new float[10];

        //string cortes;
        //float[] precioPorKilo = new float[10];
        
        
        public Persona(List<string> ListaCortes, float[] precioPorKilo)
        {
            this.ListaCortes = ListaCortes;
            this.precioPorKilo = precioPorKilo;
            
        }

        public void cargarCortesCarne()
        {
            ListaCortes.Add("Asado");
            ListaCortes.Add("Vacio");
            ListaCortes.Add("Matambre");
            ListaCortes.Add("Chorizo");
            ListaCortes.Add("Bife de chorizo");
            ListaCortes.Add("Pollo");

            

        }

  



    }
}
