using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_TrackBar
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Idade: " + (trackBar1.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            int idade;        


            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencher o nome!","Aviso Importante!", 
                MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtNome.Focus();
            }
            else
            {
                nome = txtNome.Text;

                idade = Convert.ToInt32(trackBar1.Value);

                if (idade >= 18)
                {
                    lblStatus.Text = "Maior de idade";
                }
                else
                {
                    lblStatus.Text = "Menor de idade";
                }

                lblNome.Text = nome.ToUpper();
                lblIdade.Text = idade.ToString();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar?", "Apagando os dados.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNome.Clear();
                trackBar1.Value = 0;

                lblNome.Text = "Nome:";
                lblIdade.Text = "Idade:";
                lblStatus.Text = "Maior ou Menor de idade?";
                label2.Text = "Idade:";
                txtNome.Focus();
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Tem certeza que deseja sair?", "Saindo da aplicação.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                Application.Exit();

                }
        }
    }
}
