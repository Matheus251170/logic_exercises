using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N_LIN = 3, N_COL = 3;
            int[,] mat = new int[N_LIN, N_COL];
            int l, c;

            Console.WriteLine("Cadastrando dados na matriz\n");
            Console.WriteLine("\nEntre com o valor em cada posição da matriz:\n");

            for (l = 0; l < N_LIN; l++)
            {
                for (c = 0; c < N_COL; c++)
                {
                    Console.Write(" mat [{0}][{1}]= ", l, c);
                    mat[l, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\nExibindo os dados da matriz:\n ");
            for ( l = 0; l < N_LIN; l ++ )
            {
                for(c = 0; c <N_COL; c++ )
                {
                    Console.Write(" {0} ", mat[l, c]);
                }
                Console.WriteLine();
            }

            int total1 = mat [0,0] + mat [0,1] + mat[0,2];
            Console.WriteLine("Total da linha 1 é {0}", total1);

            int total2 = mat[1, 0] + mat[1, 1] + mat[1, 2];
            Console.WriteLine("Total da linha 2 é {0}", total2);

            int total3 = mat[2, 0] + mat[2, 1] + mat[2, 2];
            Console.WriteLine("Total da linha 3 é {0}", total3);

            int total = total1 + total2 + total3;

            Console.WriteLine("O total geral é {0} ", total);

            Console.ReadKey();
        }
    }
}
