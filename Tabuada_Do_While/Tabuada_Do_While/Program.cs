using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, resp;
            
            Console.Title = "Tabuada Do_While";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            x = 1;

            do
            {
                resp = n * x;

                Console.WriteLine("{0} x {1} = {2}", n, x, resp);
                x++;

            } while (x <= 10);

            Console.ReadKey();
        }
    }
}
