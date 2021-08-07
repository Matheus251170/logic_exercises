using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_PA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double peso, altura;
            int l = 5;
            double[] imc = new double[5];

            for (l = 0; l < 5; l++)
            {
                Console.Write("\nDigite o {0}° nome: ", l + 1);
                nomes[l] = Console.ReadLine();

                Console.Write("\n\nDigite o peso de {0}: ", nomes[l]);
                peso = double.Parse(Console.ReadLine());

                Console.Write("\n\nDigite a altura de {0}: ", nomes[l]);
                altura = double.Parse(Console.ReadLine());

                imc[l] = peso / (altura * altura);
            }
            Console.WriteLine("---------Resultado--------");
            for (l = 0; l < 5; l++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Dados de {0} ", nomes[l]);

                if (imc[l] > 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} está acima do peso! Seu IMC é {1}", nomes[l], imc[l]);
                }
                else if (imc[l] < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} está abaixo do peso! Seu IMC é {1}", nomes[l], imc[l]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0} está com o peso normal! Seu IMC é {1}", nomes[l], imc[l]);
                }
            }
            Console.ReadKey();
        }
    }
}
