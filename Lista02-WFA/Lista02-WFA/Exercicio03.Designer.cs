namespace Lista02_WFA
{
    partial class Exercicio03
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnumero01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumero02 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbsomar = new System.Windows.Forms.RadioButton();
            this.rbsubtrair = new System.Windows.Forms.RadioButton();
            this.rbmultiplicar = new System.Windows.Forms.RadioButton();
            this.rbdividir = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Número ";
            // 
            // tbnumero01
            // 
            this.tbnumero01.Location = new System.Drawing.Point(31, 42);
            this.tbnumero01.Name = "tbnumero01";
            this.tbnumero01.Size = new System.Drawing.Size(100, 20);
            this.tbnumero01.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite outro Número ";
            // 
            // tbnumero02
            // 
            this.tbnumero02.Location = new System.Drawing.Point(31, 90);
            this.tbnumero02.Name = "tbnumero02";
            this.tbnumero02.Size = new System.Drawing.Size(100, 20);
            this.tbnumero02.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(31, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbsomar
            // 
            this.rbsomar.AutoSize = true;
            this.rbsomar.Location = new System.Drawing.Point(31, 132);
            this.rbsomar.Name = "rbsomar";
            this.rbsomar.Size = new System.Drawing.Size(55, 17);
            this.rbsomar.TabIndex = 5;
            this.rbsomar.TabStop = true;
            this.rbsomar.Text = "Somar";
            this.rbsomar.UseVisualStyleBackColor = true;
            // 
            // rbsubtrair
            // 
            this.rbsubtrair.AutoSize = true;
            this.rbsubtrair.Location = new System.Drawing.Point(133, 132);
            this.rbsubtrair.Name = "rbsubtrair";
            this.rbsubtrair.Size = new System.Drawing.Size(61, 17);
            this.rbsubtrair.TabIndex = 6;
            this.rbsubtrair.TabStop = true;
            this.rbsubtrair.Text = "Subtrair";
            this.rbsubtrair.UseVisualStyleBackColor = true;
            // 
            // rbmultiplicar
            // 
            this.rbmultiplicar.AutoSize = true;
            this.rbmultiplicar.Location = new System.Drawing.Point(31, 172);
            this.rbmultiplicar.Name = "rbmultiplicar";
            this.rbmultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbmultiplicar.TabIndex = 7;
            this.rbmultiplicar.TabStop = true;
            this.rbmultiplicar.Text = "Multiplicar";
            this.rbmultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbdividir
            // 
            this.rbdividir.AutoSize = true;
            this.rbdividir.Location = new System.Drawing.Point(133, 172);
            this.rbdividir.Name = "rbdividir";
            this.rbdividir.Size = new System.Drawing.Size(54, 17);
            this.rbdividir.TabIndex = 8;
            this.rbdividir.TabStop = true;
            this.rbdividir.Text = "Dividir";
            this.rbdividir.UseVisualStyleBackColor = true;
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 374);
            this.Controls.Add(this.rbdividir);
            this.Controls.Add(this.rbmultiplicar);
            this.Controls.Add(this.rbsubtrair);
            this.Controls.Add(this.rbsomar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbnumero02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnumero01);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio03";
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnumero01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumero02;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbsomar;
        private System.Windows.Forms.RadioButton rbsubtrair;
        private System.Windows.Forms.RadioButton rbmultiplicar;
        private System.Windows.Forms.RadioButton rbdividir;
    }
}