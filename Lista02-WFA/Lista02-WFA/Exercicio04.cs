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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double validarnome = Convert.ToDouble(tbnumero.Text);
            }
            catch
            {
                MessageBox.Show("Caro Usuário,digite apenas números :) ");
                tbnumero.Focus();
                return;
            }
            
        
            double numero01 = Convert.ToDouble(tbnumero.Text);

            if (numero01 % 2 == 0)
            {
                MessageBox.Show("O número " + numero01 + " é Par");
            }
            else if (numero01 % 2 == 1)
            {
                MessageBox.Show("O número " + numero01 + " Ímpar");
            }
            else
            {
                MessageBox.Show("O número " + numero01 + " é Netro");
            }

        }
    }
}
