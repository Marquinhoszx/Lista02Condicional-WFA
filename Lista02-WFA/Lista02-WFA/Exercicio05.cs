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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
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
                MessageBox.Show("Digite apenas números");
                tbnumero.Focus();
                return;
            }

            double numero = Convert.ToDouble(tbnumero.Text);

            if (numero % 2 != 0)
            {
                MessageBox.Show("O número " + numero + " é Par");
            }
            else if (numero % 2 == 1)
            {
                MessageBox.Show("O número " + numero + " é Ímpar");
            }
            else
            {
                MessageBox.Show("O número " + numero + " é Netro");
            }





        }
    }
}
