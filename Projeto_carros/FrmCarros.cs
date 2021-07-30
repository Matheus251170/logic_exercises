using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCarros
{
    public partial class FrmCarros : Form
    {

        double preco=0;
        string motor = "", versao = "", cor = "", acessorio1 = "", acessorio2 = "", acessorio3 = "", acessorio4 = "", acessorio5 = "", acessorio6 = "";




        public FrmCarros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // definir tipo de carro
            if (cboModelo.SelectedIndex == 0)
            {
                preco = 30000;
            }
            else if (cboModelo.SelectedIndex == 1)
            {
                preco = 45000; 
            }
            
            else if (cboModelo.SelectedIndex == 2)
            {
                preco = 60000;
            }
            else if (cboModelo.SelectedIndex == -1)
            {
                preco = 0;
            }

            // definindo motor

            if (rb14.Checked)
            {
                preco += 2000;
                motor = rb14.Text;
            }

            if (rb20.Checked)
            {
                preco += 4000;
                motor = rb20.Text;
            }

            if (rb1.Checked)
            {
                preco += 000;
                motor = rb1.Text;
            }

            //definir versão

            if (radBtm1.Checked)
            {
                versao = radBtm1.Text;
            }

            if (radBtn2.Checked)
            {
                preco += 2000;
                versao = radBtn2.Text;
            }

            if (radBtn3.Checked)
            {
                preco += 3000;
                versao = radBtn3.Text;
            }

            //definir cor

            if (radCor1.Checked)
            {
                cor = radCor1.Text;
            }

            if (radCor2.Checked)
            {
                preco += 1000;
                cor = radCor2.Text;
            }

            if (radCor3.Checked)
            {
                preco += 2000;
                cor = radCor3.Text;
            }

            //acessório

            if (chkBox1.Checked)
            {
                preco += 800;
                acessorio1 = chkBox1.Text;
            }

            if (chkBox2.Checked)
            {
                preco += 2000;
                acessorio2 = chkBox2.Text;                
            }

            if (chkBox3.Checked)
            {
                preco += 2000;
                acessorio3 = chkBox3.Text;
            }

            if (chkBox4.Checked)
            {
                preco += 2000;
                acessorio4= chkBox4.Text;
            }

            if (chkBox5.Checked)
            {
                preco += 15000;
                acessorio5 = chkBox5.Text;
            }

            if (chkBox6.Checked)
            {
                preco += 1000;
                acessorio6 = chkBox6.Text;
            }






            //exibindo total 
            txtTotal.Text = preco.ToString("C");


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            cboModelo.SelectedIndex = -1;
            lstLista.Items.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();

            lstLista.Items.Add("Escolhas do cliente referente ao carro: ");
            lstLista.Items.Add("");
            lstLista.Items.Add("\n\n" + lblModelo.Text + " " + cboModelo.Text);
            lstLista.Items.Add("Motor: " + motor);
            lstLista.Items.Add(versao);
            lstLista.Items.Add(cor);

            lstLista.Items.Add("");
            lstLista.Items.Add(acessorio1);
            lstLista.Items.Add(acessorio2);
            lstLista.Items.Add(acessorio3);
            lstLista.Items.Add(acessorio4);
            lstLista.Items.Add(acessorio5);
            lstLista.Items.Add(acessorio6);



            lstLista.Items.Add("");
            lstLista.Items.Add("------------------------------");
            lstLista.Items.Add("Total: "+ txtTotal.Text);
        }

        private void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
