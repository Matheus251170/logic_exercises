using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatoracionWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, fatorial;
            fatorial = 1;

            Console.Title = "Fatoração While";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Escolha um número para fatorar: ");
            x = int.Parse(Console.ReadLine());

            while (x >= 1)
            {           
                fatorial = fatorial *= x;
                x--;
            }
            Console.Write("O fatorial é " + fatorial);
            Console.ReadKey();
        }
    }
}
