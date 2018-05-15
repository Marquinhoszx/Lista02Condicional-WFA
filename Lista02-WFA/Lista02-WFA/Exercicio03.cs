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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero01 = Convert.ToDouble(tbnumero01.Text);
            double numero02 = Convert.ToDouble(tbnumero02.Text);
            
            
            if (rbsomar.Checked)
            {
                double soma = numero01 + numero02;
                MessageBox.Show("A soma dos números é " + soma);
            }
            if (rbsubtrair.Checked)
            {
                double subtrair = numero01 - numero02;
                MessageBox.Show("A subtração dos números é " + subtrair);
            }
            if (rbmultiplicar.Checked)
            {
                double multiplicacao = numero01 * numero02;
                MessageBox.Show("A multiplicação dos números é " + multiplicacao);
            }
            if (rbdividir.Checked)
            {
                double dividir = numero01 / numero02;
                MessageBox.Show("A divisisão dos números è " + dividir);
            }
        }
    }
}
