using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista02_WFA
{
    public partial class Exercicio12 : Form
    {

        double numeromaior = 0;

        public Exercicio12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnumero1 = Convert.ToDouble(tbNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Está escrito Número,Não Letras/Palavras");
                tbNumero1.Focus();
                return;
            }
            try
            {
                double validarnumero2 = Convert.ToDouble(tbNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Está escrito Número,Não letras/palavras");
                tbNumero2.Focus();
                return;
            }

            double numero1 = Convert.ToDouble(tbNumero1.Text);
            double numero2 = Convert.ToDouble(tbNumero2.Text);

            if (numero1 > numeromaior)
            {
                numeromaior = numero1;
            }
            else if (numero2 > numeromaior)
            {
                numeromaior = numero2;
            }

            label3.Text = "Maior Número: " + numeromaior;

        }
    }
}
