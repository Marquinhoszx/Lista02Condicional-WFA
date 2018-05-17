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


        double pedido01 = 0, pedido02 = 0, pedido03 = 0;

        public Exercicio08()
        {
            InitializeComponent();

            Tabela();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validacao
            Total();



        }
        private void Pedido01()
        {

            try
            {
                
                int numeroPedido01 = Convert.ToInt32(tbpedido01.Text);

                


                if (numeroPedido01 == 1)
                {
                    pedido01 = preco1;
                }
                else if (numeroPedido01 == 2)
                {
                    pedido01 = preco2;
                }
                else if (numeroPedido01 == 3)
                {
                    pedido01 = preco3;
                }
                else if (numeroPedido01 == 4)
                {
                    pedido01 = preco4;
                }
                else if (numeroPedido01 == 5)
                {
                    pedido01 = preco5;
                }
                else if (numeroPedido01 == 6)
                {
                    pedido01 = preco6;
                }
                else if (numeroPedido01 == 7)
                {
                    pedido01 = preco7;
                }
                else if (numeroPedido01 == 8)
                {
                    pedido01 = preco8;
                }
                else if (numeroPedido01 == 9)
                {
                    pedido01 = preco9;
                }
                else if (numeroPedido01 == 10)
                {
                    pedido01 = preco10;
                }
                else if (numeroPedido01 == 11)
                {
                    pedido01 = preco11;
                }
                else if (numeroPedido01 == 12)
                {
                    pedido01 = preco12;
                }
                else if (numeroPedido01 == 13)
                {
                    pedido01 = preco13;
                }
                else if (numeroPedido01 == 14)
                {
                    pedido01 = preco14;
                }
                else if (numeroPedido01 == 15)
                {
                    pedido01 = preco15;
                }
            }
            catch
            {
                MessageBox.Show("Apenas números de 1 a 15");
                tbpedido01.Focus();
                return;
            }




        }
        private void Pedido02()
        {
            int numeroPedidio02 = Convert.ToInt32(tbpedido02.Text);
            if (numeroPedidio02 == 1)
            {
                pedido02 = preco1;
            }
            else if (numeroPedidio02 == 2)
            {
                pedido02 = preco2;
            }
            else if (numeroPedidio02 == 3)
            {
                pedido02 = preco3;
            }
            else if (numeroPedidio02 == 4)
            {
                pedido02 = preco4;
            }
            else if (numeroPedidio02 == 5)
            {
                pedido02 = preco5;
            }
            else if (numeroPedidio02 == 6)
            {
                pedido02 = preco6;
            }
            else if (numeroPedidio02 == 7)
            {
                pedido02 = preco7;
            }
            else if (numeroPedidio02 == 8)
            {
                pedido02 = preco8;
            }
            else if (numeroPedidio02 == 9)
            {
                pedido02 = preco9;
            }
            else if (numeroPedidio02 == 10)
            {
                pedido02 = preco10;
            }
            else if (numeroPedidio02 == 11)
            {
                pedido02 = preco11;
            }
            else if (numeroPedidio02 == 12)
            {
                pedido02 = preco12;
            }
            else if (numeroPedidio02 == 13)
            {
                pedido02 = preco13;
            }
            else if (numeroPedidio02 == 14)
            {
                pedido02 = preco14;
            }
            else if (numeroPedidio02 == 15)
            {
                pedido02 = preco15;
            }
        }
        private void Pedido03()
        {
            int numeroPedido03 = Convert.ToInt32(tbpedido03.Text);
            if (numeroPedido03 == 1)
            {
                pedido03 = preco1;
            }
            else if (numeroPedido03 == 2)
            {
                pedido03 = preco2;
            }
            else if (numeroPedido03 == 3)
            {
                pedido03 = preco3;
            }
            else if (numeroPedido03 == 4)
            {
                pedido03 = preco4;
            }
            else if (numeroPedido03 == 5)
            {
                pedido03 = preco5;
            }
            else if (numeroPedido03 == 6)
            {
                pedido03 = preco6;
            }
            else if (numeroPedido03 == 7)
            {
                pedido03 = preco7;
            }
            else if (numeroPedido03 == 8)
            {
                pedido03 = preco8;
            }
            else if (numeroPedido03 == 9)
            {
                pedido03 = preco9;
            }
            else if (numeroPedido03 == 10)
            {
                pedido03 = preco10;
            }
            else if (numeroPedido03 == 11)
            {
                pedido03 = preco11;
            }
            else if (numeroPedido03 == 12)
            {
                pedido03 = preco12;
            }
            else if (numeroPedido03 == 13)
            {
                pedido03 = preco13;
            }
            else if (numeroPedido03 == 14)
            {
                pedido03 = preco14;
            }
            else if (numeroPedido03 == 15)
            {
                pedido03 = preco15;
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

        private void Total()
        {
            Pedido01();
            Pedido02();
            Pedido03();
            double total = pedido01 + pedido02 + pedido03;
            label4.Text = string.Format("Total à pagar: {0:c}", total);






        }
    }
}

