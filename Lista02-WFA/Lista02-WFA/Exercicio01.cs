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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnumero01 = Convert.ToDouble(tbnumero01.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números");
                tbnumero01.Focus();
                return;
            }

            double numero01 = Convert.ToDouble(tbnumero01.Text);

            if (numero01 >= 1)
            {
                MessageBox.Show("O número " + numero01 + " é positivo");
            }
            else if (numero01 < 0)
            {
                MessageBox.Show("O número " + numero01 + " é negativo");
            }
            else
            {
                MessageBox.Show("O número " + numero01 + " é neutro");
            }





        }
    }
}
