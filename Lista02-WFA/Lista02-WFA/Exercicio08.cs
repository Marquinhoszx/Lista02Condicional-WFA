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
    public partial class Exercicio08 : Form
    {

        double preco1 = 29.50;
        double preco2 = 2.00;
        double preco3 = 29.23;
        double preco4 = 7.10;
        double preco5 = 19.33;
        double preco6 = 17.71;
        double preco7 = 4.82;
        double preco8 = 21.16;
        double preco9 = 12.70;
        double preco10 = 19.70;
        double preco11 = 28.22;
        double preco12 = 8.98;
        double preco13 = 0.42;
        double preco14 = 18.36;
        double preco15 = 27.50;

        public Exercicio08()
        {
            InitializeComponent();
            Tabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validacao

            try
            {
                double validarpedido01 = Convert.ToDouble(tbpedido01.Text);
            }
            catch
            {
                MessageBox.Show("Pedido apenas com números");
                tbpedido01.Focus();
                return;
            }
            try
            {
                double validarpedido02 = Convert.ToDouble(tbpedido02.Text);
            }
            catch
            {
                MessageBox.Show("Pedido apenas com número");
                tbpedido02.Focus();
                return;
            }
            try
            {
                double validarpedido03 = Convert.ToDouble(tbpedido03.Text);
            }
            catch
            {
                MessageBox.Show("Pedido apenas com números");
                tbpedido03.Focus();
                return;
            }

            double pedido01 = Convert.ToDouble(tbpedido01.Text);
            double pedido02 = Convert.ToDouble(tbpedido02.Text);
            double pedido03 = Convert.ToDouble(tbpedido03.Text);




        }
        private void variaveis()
        {

            if (preco1 == 1)
            {
                
            }
            

        }





        private void Tabela()
        {
            lbresultado.Text =
             @"                           
1  |Bolos                 |Bolo Brigadeiro                                                      |R$29,50
2  |Bolos                 |Bolo Floresta negra                                               |R$ 2,00
3  |Bolos                 |Bolo Leite com nutella                                           |R$29,23
4  |Bolos                 |Bolo Mousse de Chocolate                                   |R$ 7,10
5  |Bolos                 |Bolo Nega maluca                                                 |R$19,33
6  |Doces                |Bomba de creme                                                  |R$17,71
7  |Doces                |Bomba de chocolate                                            |R$ 4,82
8  |Sanduiches       |Fíle-mignom com fritas e cheddar                         |R$21,16
9  |Sanduiches       |Hambúrguer com queijo,champignon e rucula      |R$12,70
10 |Sanduiches      |Provolone com salame                                          |R$19,70
11 |Sanduiches      |Vegetariano com berinjela                                     |R$28,22
12 |Pizzas               |Calabresa                                                              |R$ 8,98
13 |Pizzas               |Napolitana                                                             |R$ 0,42
14 |Pizzas               |Peruana                                                                 |R$18,36
15 |Pizzas               |Portuguesa                                                            |R$27,50";

        }

        private void Compra()
        {
            




        }
    }

}
