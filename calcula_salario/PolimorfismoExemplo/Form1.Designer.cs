namespace PolimorfismoExemplo
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDesigner = new System.Windows.Forms.RadioButton();
            this.rbProgramador = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbDWeb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(21, 88);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario:";
            // 
            // rbDesigner
            // 
            this.rbDesigner.AutoSize = true;
            this.rbDesigner.Location = new System.Drawing.Point(21, 114);
            this.rbDesigner.Name = "rbDesigner";
            this.rbDesigner.Size = new System.Drawing.Size(67, 17);
            this.rbDesigner.TabIndex = 4;
            this.rbDesigner.TabStop = true;
            this.rbDesigner.Text = "Designer";
            this.rbDesigner.UseVisualStyleBackColor = true;
            this.rbDesigner.CheckedChanged += new System.EventHandler(this.rbDesigner_CheckedChanged);
            // 
            // rbProgramador
            // 
            this.rbProgramador.AutoSize = true;
            this.rbProgramador.Location = new System.Drawing.Point(21, 152);
            this.rbProgramador.Name = "rbProgramador";
            this.rbProgramador.Size = new System.Drawing.Size(85, 17);
            this.rbProgramador.TabIndex = 5;
            this.rbProgramador.TabStop = true;
            this.rbProgramador.Text = "Programador";
            this.rbProgramador.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reajustar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(21, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // rbDWeb
            // 
            this.rbDWeb.AutoSize = true;
            this.rbDWeb.Location = new System.Drawing.Point(21, 192);
            this.rbDWeb.Name = "rbDWeb";
            this.rbDWeb.Size = new System.Drawing.Size(123, 17);
            this.rbDWeb.TabIndex = 8;
            this.rbDWeb.TabStop = true;
            this.rbDWeb.Text = "Desenvolvedor Web";
            this.rbDWeb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 277);
            this.Controls.Add(this.rbDWeb);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbProgramador);
            this.Controls.Add(this.rbDesigner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Polimorfismo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDesigner;
        private System.Windows.Forms.RadioButton rbProgramador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbDWeb;
    }
}

