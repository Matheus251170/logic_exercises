using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = { { 1, 42, 23, 14, 51 }, { 22, 32, 55, 54, 12 } };

            int x, y, quantidade;

            Console.WriteLine("\n Exibindo apenas os elementos pares da matriz:\n");

            for(x = 0; x < 2; x++)
            {
                quantidade = 0;

                for(y = 0; y < 5; y++)
                {
                    if (mat[x, y] % 2 == 0)
                    {
                        Console.Write(" {0:D2}  ", mat[x, y]);
                        quantidade++;
                    }

                    else
                    {
                        Console.Write("  -  ");
                    }
                }
                Console.WriteLine("O total de pares é: {0}", quantidade);
            }
            Console.ReadKey();
        }
    }
}
