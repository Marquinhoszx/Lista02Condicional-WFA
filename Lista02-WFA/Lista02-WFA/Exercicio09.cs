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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void btncgo_Click(object sender, EventArgs e)
        {
           
            //Validação
            
            try
            {
                double validarnumero1 = Convert.ToInt32(tbNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas números");
                tbNumero1.Focus();
                return;
            }
            try
            {
                double validarNumero2 = Convert.ToDouble(tbNumero2.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNumero2.Focus();
                return;
            }
            try
            {
                double validarNumero3 = Convert.ToDouble(tbNumero3.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNumero3.Focus();
                return;
            }
            try
            {
                double validarNumero4 = Convert.ToDouble(tbNumero4.Text);
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

            //IFs

            if ((numero1 == numero2) && (numero3 == numero4))
            {
                label5.Text = "É um quadrado";
            }
            else
            {
                label5.Text = "Pena Filão,Não é um quadrado";
            }



        }


    }
}
