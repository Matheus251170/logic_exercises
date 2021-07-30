namespace Encapsulamento18092020
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rbPrato = new System.Windows.Forms.RadioButton();
            this.rbMarmitex = new System.Windows.Forms.RadioButton();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infome o peso em gramas:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(34, 42);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(105, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // rbPrato
            // 
            this.rbPrato.AutoSize = true;
            this.rbPrato.Location = new System.Drawing.Point(34, 85);
            this.rbPrato.Name = "rbPrato";
            this.rbPrato.Size = new System.Drawing.Size(50, 17);
            this.rbPrato.TabIndex = 2;
            this.rbPrato.TabStop = true;
            this.rbPrato.Text = "Prato";
            this.rbPrato.UseVisualStyleBackColor = true;
            // 
            // rbMarmitex
            // 
            this.rbMarmitex.AutoSize = true;
            this.rbMarmitex.Location = new System.Drawing.Point(34, 120);
            this.rbMarmitex.Name = "rbMarmitex";
            this.rbMarmitex.Size = new System.Drawing.Size(67, 17);
            this.rbMarmitex.TabIndex = 3;
            this.rbMarmitex.TabStop = true;
            this.rbMarmitex.Text = "Marmitex";
            this.rbMarmitex.UseVisualStyleBackColor = true;
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Location = new System.Drawing.Point(31, 216);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoFinal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço Final:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 271);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecoFinal);
            this.Controls.Add(this.rbMarmitex);
            this.Controls.Add(this.rbPrato);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rbPrato;
        private System.Windows.Forms.RadioButton rbMarmitex;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
    }
}

