using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCarniceria
{
    public partial class FrmComprador : Form
    {
        Comprador miComprador;
        public FrmComprador()
        {
            InitializeComponent();

        }

        public FrmComprador(Comprador comprador):this()
        {
            this.miComprador = comprador;
            MessageBox.Show($"Bienvenido {this.miComprador.Email}");

        }

    }
}
