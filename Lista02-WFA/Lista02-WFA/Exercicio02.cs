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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnumero01 = Convert.ToDouble(tbnumero01.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números XD!!!");
                tbnumero01.Focus();
                return;
            }

            double numero01 = Convert.ToDouble(tbnumero01.Text);

            if (numero01 >= 1)
            {
                MessageBox.Show("O número "+ numero01 + " é positivo");
            }
            else if (numero01 < 0)
            {
                MessageBox.Show("O número " + numero01 + " é negativo");
            }
            else
            {
                MessageBox.Show("O Número " + numero01 + " é Neutro");
            }


        }
    }
}
