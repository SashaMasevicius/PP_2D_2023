using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        eCarne tipoCarne;
        float peso;
        double precioPorKg;

        public Producto(eCarne tipoCarne, float peso, double precioPorKg)
        {
            this.TipoCarne = tipoCarne;
            this.peso = peso;
            this.precioPorKg = precioPorKg;
        }

        public float Peso 
        { 
            get => peso; 
            set => peso = value; 
        }
        public double PrecioPorKg 
        { 
            get => precioPorKg;
            set => precioPorKg = value; 
        }
        public eCarne TipoCarne { get => tipoCarne; set => tipoCarne = value; }
    }
}
