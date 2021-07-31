using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfismoExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Programador p1 = new Programador(); //recebe os valores da classe Programador
            Designer d1 = new Designer(); //recebe os valores da classe Designer
            DesenvolvedorWeb dw1 = new DesenvolvedorWeb(); //receb os valores da classe Desenvolvedor Web

            decimal salario=0; //definição de variavel
            string nome=""; //definição de variavel

            try //caso o usuario não digite o valor corretamente, será exibida uma mensagem de erro
            {
                salario = Convert.ToDecimal(txtSalario.Text); //convertendo o valor inserido pelo usuario para decimal
                nome = txtNome.Text; //convertendo a instrução fornecida pelo usuario para texto

                if (rbDesigner.Checked) //caso a opção de Designer seja marcado no form, faça:
                {
                    d1.salario = salario; //d1 se junta com o valor sálario recebendo o valor do mesmo
                    d1.Rejustar(); //a variavel recebe o valor do metodo reajustar através do override
                    lblResultado.Text = d1.salario.ToString(); ////exibe o resultado reajustado pelo metodo
                }
                else if (rbProgramador.Checked) //caso a opção Programador seja marcada no form, faça:
                {
                    p1.salario = salario; //p1 se junta com o valor sálario recebendo o valor do mesmo
                    p1.Rejustar(); //a variavel recebe o valor do metodo reajustar através do override
                    lblResultado.Text = p1.salario.ToString(); //exibe o resultado reajustado pelo metodo
                }
                else if (rbDWeb.Checked) //caso a opção Desenvolvedor Web seja marcada no form, faça:
                {
                    dw1.salario = salario; //dw1 se junta com o valor sálario recebendo o valor do mesmo
                    dw1.Rejustar(); //a variavel salario recebe o valor do metodo reajustar através do override
                    lblResultado.Text = dw1.salario.ToString(); //exibe o resultado reajustado pelo metodo
                }
                else
                {
                    lblResultado.Text = "0"; //caso nenhuma das opções tenha sido marcada, o resultado no label será 0
                }

            }

            catch
            {
                MessageBox.Show("Digite um valor para o salário!"); //mensagem exibida caso o usuario não forneça o valor do salario
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDesigner_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
