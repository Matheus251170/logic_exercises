using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento18092020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clComida_Kilo kilo = new clComida_Kilo();

            double peso = double.Parse(txtPeso.Text);

            int tipo;

            if (rbPrato.Checked)
            {
                tipo = 1;

            }else if (rbMarmitex.Checked)
            {
                tipo = 2;
            }
            else
            {
                tipo = 0;
            }

            txtPrecoFinal.Text = kilo.CalcularPrecoFinal(peso, tipo).ToString("C");
        }
    }
}
