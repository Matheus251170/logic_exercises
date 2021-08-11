using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Diferença";

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            int x, n, valor;
           
            Console.Write("Digite o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n = int.Parse(Console.ReadLine());


             valor = Diferenca(x, n);

            Console.WriteLine("\n\nA diferença entre os números é {0}!", valor);
            Console.ReadKey();
        }

        static int Diferenca(int x, int n)
        {
            int dif = x - n;
            return dif;
           
        }
    }
}
