namespace Lista02_WFA
{
    partial class Exercicio08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpedido01 = new System.Windows.Forms.TextBox();
            this.tbpedido02 = new System.Windows.Forms.TextBox();
            this.tbpedido03 = new System.Windows.Forms.TextBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(448, 369);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(134, 32);
            this.btnFinalizarCompra.TabIndex = 0;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedido02";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pedido03";
            // 
            // tbpedido01
            // 
            this.tbpedido01.Location = new System.Drawing.Point(86, 37);
            this.tbpedido01.Name = "tbpedido01";
            this.tbpedido01.Size = new System.Drawing.Size(100, 20);
            this.tbpedido01.TabIndex = 4;
            // 
            // tbpedido02
            // 
            this.tbpedido02.Location = new System.Drawing.Point(86, 80);
            this.tbpedido02.Name = "tbpedido02";
            this.tbpedido02.Size = new System.Drawing.Size(100, 20);
            this.tbpedido02.TabIndex = 5;
            // 
            // tbpedido03
            // 
            this.tbpedido03.Location = new System.Drawing.Point(86, 124);
            this.tbpedido03.Name = "tbpedido03";
            this.tbpedido03.Size = new System.Drawing.Size(100, 20);
            this.tbpedido03.TabIndex = 6;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(208, 44);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(0, 13);
            this.lbresultado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // Exercicio08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.tbpedido03);
            this.Controls.Add(this.tbpedido02);
            this.Controls.Add(this.tbpedido01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Name = "Exercicio08";
            this.Text = "Exercicio08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbpedido01;
        private System.Windows.Forms.TextBox tbpedido02;
        private System.Windows.Forms.TextBox tbpedido03;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Label label4;
    }
}