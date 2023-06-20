using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentasHistorial
    {
        int id;
        string comprador;
        string corte;
        int kilos;
        double totalVenta;


        public VentasHistorial(int id, string comprador, string corte, int kilos, double totalVenta)
            :this(comprador, corte, kilos, totalVenta)
        {
            this.id = id;
            this.comprador = comprador;
            this.corte = corte;
            this.kilos = kilos;
            this.totalVenta = totalVenta;
        }


    public VentasHistorial(string comprador, string corte, int kilos, double totalVenta)
        {
            this.comprador = comprador;
            this.corte = corte;
            this.kilos = kilos;
            this.totalVenta = totalVenta;
        }


        public int Id { get => id; set => id = value; }
        public string Comprador { get => comprador; set => comprador = value; }
        public string Corte { get => corte; set => corte = value; }
        public int Kilos { get => kilos; set => kilos = value; }
        public double TotalVenta { get => totalVenta; set => totalVenta = value; }
        

        public override string ToString()
        {
            return $"{Id},{Comprador},{Corte},{Kilos}, {TotalVenta}";
        }
    }
}
