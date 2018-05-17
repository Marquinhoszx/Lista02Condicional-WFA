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
    public partial class Exercicio13 : Form
    {

        double numeromenor = int.MaxValue; 
        public Exercicio13()
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
                MessageBox.Show("Mano está escrito número ,não letras/palavras   XD");
                tbNumero1.Focus();
                return;
            }
            try
            {
                double validarnumero2 = Convert.ToDouble(tbNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Mano está escrito número,não Letras/palavras");
                tbNumero2.Focus();
                return;
            }

            double numero1 = Convert.ToDouble(tbNumero1.Text);
            double numero2 = Convert.ToDouble(tbNumero2.Text);


            if (numero1 < numeromenor)
            {
                numeromenor = numero1;
            }
            else if (numero2 < numeromenor)
            {
                numeromenor = numero2;
            }

            label3.Text = "Menor Número" + numeromenor;

        }

        
    }
}
