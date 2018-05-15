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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnumero = Convert.ToDouble(tbnumero.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números amigão XD");
                tbnumero.Focus();
                return;
            }
            double numero = Convert.ToDouble(tbnumero.Text);

            if (numero != 1)
            {
                MessageBox.Show("O Número " + numero + " é diferente de 1");
            }
            else
            {
                MessageBox.Show("o numero digitado é o número 1 BRo");
            }







        }

        
    }
}
