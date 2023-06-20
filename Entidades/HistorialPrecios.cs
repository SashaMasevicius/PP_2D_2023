using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialPrecios
    {
        private DateTime fecha;
        private string corteDeCarne;
        private decimal nuevoPrecio;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string CorteDeCarne { get => corteDeCarne; set => corteDeCarne = value; }
        public decimal NuevoPrecio { get => nuevoPrecio; set => nuevoPrecio = value; }

        public HistorialPrecios(DateTime fecha, string corteDeCarne, decimal nuevoPrecio)
        {
            this.fecha = fecha;
            this.corteDeCarne = corteDeCarne;
            this.nuevoPrecio = nuevoPrecio;
        }

        public override string ToString()
        {
            return $"{Fecha},{CorteDeCarne},{NuevoPrecio}";
        }
    }
}
