using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cofre
{
    public partial class Form1 : Form
    {
        Cofre cofre = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cofre = new Cofre();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirMoeda_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out _))
            {
                var moeda = new Moeda();
                moeda.SetValor(Convert.ToDouble(textBox1.Text));
                cofre.InserirMoedas(moeda);
                lbQtdMoeda.Text = cofre.QuantidadeMoedas().ToString();
                lbValorDolar.Text = cofre.ValotTotalDolar().ToString("F2");
                lbValorReal.Text = cofre.ValorTotalReais().ToString("F2");
                lbMoedasUmReal.Text = cofre.QuantidadeMoedasUmReal().ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
