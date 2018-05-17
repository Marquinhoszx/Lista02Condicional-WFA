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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnota1 = Convert.ToDouble(tbNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números  XD");
                tbNumero1.Focus();
                return;
            }
            try
            {
                double validarnota2 = Convert.ToDouble(tbNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNumero2.Focus();
                return;
            }
            try
            {
                double validarnota3 = Convert.ToDouble(tbNumero3.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNumero3.Focus();
                return;
            }
            try
            {
                double valdiarnota4 = Convert.ToDouble(tbNumero4.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNumero4.Focus();
                return;
            }

            double numero1 = Convert.ToDouble(tbNumero1.Text);
            double numero2 = Convert.ToDouble(tbNumero2.Text);
            double numero3 = Convert.ToDouble(tbNumero3.Text);
            double numero4 = Convert.ToDouble(tbNumero4.Text);

            if ((numero1 == numero2) || (numero1 != numero4))
            {
                if (numero1 != numero3)
                {
                    label5.Text = "É um retanguçlo";
                }
            }
            else
            {
                label5.Text = "Não é um Retangulo";
            }

        }
    }
}
