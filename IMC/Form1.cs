using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_Pessoa p1 = new cl_Pessoa();

            p1.nome = txtNome.Text;
            p1.sobrenome = txtSobrenome.Text;
            p1.idade = int.Parse(txtIdade.Text);

            p1.peso = double.Parse(txtPeso.Text);
            p1.altura = double.Parse(txtAltura.Text);


            p1.falar();          
            

            lblResultado.Text = p1.definirmaiormenor(p1.idade);

            lblResultIMC.Text = p1.calcularIMC(p1.peso, p1.altura);           
            
            lblImc.Text = p1.imc.ToString();
        }
    }
}
