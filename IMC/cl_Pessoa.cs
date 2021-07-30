using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoa
{
    class cl_Pessoa
    {
        // atributos
        public string nome;
        public string sobrenome;
        public int idade;
        public double peso;
        public double altura;
        public double imc;

       
        // método sem retorno e sem parâmetro.
        public void falar()
        {
            System.Windows.Forms.MessageBox.Show("Olá, meu nome é " + nome + " e tenho " + idade + " de idade!");
        }

        // método do tipo sem parâmetro mas com retorno.
        public string nomeCompleto()
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        // método do tipo com parâmetro e com retorno
        public string definirmaiormenor(int idade)
        {
            if (idade >= 18)
            {
                return " é maior de idade";
            }
            else
            {
                return "é menor de idade";
            }
        }

        public string calcularIMC(double peso, double altura)
        {
            imc = peso / (altura * altura);

            if (imc > 25)
            {
                return "Acima do peso";

            }else if(imc < 17)
            {
                return "Abaixo do peso";
            }
            else
            {
                return "Peso Normal";
            }

        }

    }
}
