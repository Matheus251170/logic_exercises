using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = { { 4.5, 5.2 }, { 4.2, 1 } };

            int x, y;

            Console.WriteLine("\nImprimindo a matriz:\n");
            for(x = 0; x < 2; x++)
            {
                for(y = 0; y < 2; y ++)
                {
                    Console.WriteLine("\n mat [{0}][{1}] = {2:N1}", x, y, matriz[x, y]);
                }
            }
            double total1 = (matriz[0,0] + matriz[0,1]) / 2;
            Console.WriteLine("\n\nMédia da linha 1 é: {0}", total1);

            double total2 = (matriz[1, 0] + matriz[1, 1]) / 2;
            Console.WriteLine("\n\n Média da linha 2 é: {0}", total2);

            double total = (total1 + total2)/2 ;

            Console.WriteLine("\n\nA média geral é {0} ", total);
            Console.ReadKey();
        }
    }
}
