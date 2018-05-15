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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validacao

            try
            {
                double validarnumero = Convert.ToDouble(tbnumero.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas número caro usuário");
                tbnumero.Focus();
                return;
            }
            
            //número

            double numero = Convert.ToDouble(tbnumero.Text);

            //Par impar NEUTRO

            if (numero % 2 == 0)
            {
                txtresultado.Text += "\n é Par, "; 
                
            }
            else if (numero % 2 == 1)
            {
                txtresultado.Text += "\n é impar, ";
                
            }
            else
            {
                txtresultado.Text = "\n é neutro, ";
            }

            //positivo ou negativo

            if (numero >= 1)
            {
                txtresultado.Text += "\n é positivo, ";
            }
            else if(numero < 0)
            {
               txtresultado.Text +="O número é negativo, ";
            }
            else
            {
                txtresultado.Text += "O número é neutro, ";
            }

            //se o numero é maior que 10

            if (numero > 10)
            {
                txtresultado.Text += "O número é maior que 10, ";
            }
            else
            {
                txtresultado.Text += "O númeo não é maior que 10, ";
            }

            // numero menor que 50

            if (numero < 50)
            {
                txtresultado.Text += "O número é menor que 50, ";
            }
            else
            {
                txtresultado.Text += "O número é maior que 50, ";
            }

            // menor que 50

            if (numero < -10)
            {
                txtresultado.Text += "O número é menor que -10, ";
            }
            else
            {
                txtresultado.Text += "O número é maior que -10, ";
            }

            //maior ou igual a 30

            if (numero >= 30)
            {
                txtresultado.Text += "O número é maior que 30, ";
            }
            else
            {
                txtresultado.Text += "O número é menor que 30, ";
            }

            //numero é diferente de 1

            if (numero != 1)
            {
                txtresultado.Text += "O número é diferente de 1, ";
            }
            else
            {
                txtresultado.Text += "é o número 1, ";
            }
        }
    }
}
