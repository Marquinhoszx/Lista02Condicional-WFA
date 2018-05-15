namespace Lista02_WFA
{
    partial class Exercicio07
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnumero = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(116, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Olá,eu sou um botão,ou seja,me aperte para continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caro usuário,digite um número";
            // 
            // tbnumero
            // 
            this.tbnumero.Location = new System.Drawing.Point(116, 107);
            this.tbnumero.Name = "tbnumero";
            this.tbnumero.Size = new System.Drawing.Size(152, 20);
            this.tbnumero.TabIndex = 2;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(3, 146);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(393, 76);
            this.txtresultado.TabIndex = 3;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 409);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.tbnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnumero;
        private System.Windows.Forms.TextBox txtresultado;
    }
}