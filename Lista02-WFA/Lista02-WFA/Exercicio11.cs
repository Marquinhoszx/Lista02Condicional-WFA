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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnota1 = Convert.ToDouble(tbNota1.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNota1.Focus();
                return;
            }
            try
            {
                double validarnota2 = Convert.ToDouble(tbNota2.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNota2.Focus();
                return;
            }
            try
            {
                double validarnota3 = Convert.ToDouble(tbNota3.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNota3.Focus();
                return;
            }
            try
            {
                double validarnota4 = Convert.ToDouble(tbNota4.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNota4.Focus();
                return;
            }
            try
            {
                double validarnota5 = Convert.ToDouble(tbNota5.Text);
            }
            catch
            {
                MessageBox.Show("Opaaa Fion,Apenas Números");
                tbNota5.Focus();
                return;
            }

            double nota1 = Convert.ToDouble(tbNota1.Text);
            double nota2 = Convert.ToDouble(tbNota2.Text);
            double nota3 = Convert.ToDouble(tbNota3.Text);
            double nota4 = Convert.ToDouble(tbNota4.Text);
            double nota5 = Convert.ToDouble(tbNota5.Text);

            double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            label6.Text = "Média: " + media;

            if (media <= 5)
            {
                label6.Text = "Sua Média foi de " + media + "\r\nReprovado ....feels bad";
            }
            else if (media < 7)
            {
                label6.Text = "Sua Média foi de " + media + "\r\nQuase Man,Exame";
            }
            else if (media >= 7)
            {
                label6.Text = "Sua Média foi de " + media + "\r\nGG Passou";
            }





        }
    }
}
