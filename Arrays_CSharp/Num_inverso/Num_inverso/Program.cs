using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_inverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int[] numeros = new int[10];

            Console.Write("Insira o primeiro número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            for (i = 0; i < numeros.Length; i++)
                numeros[i] = (i + 1) + num;

            for (i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("{0}", numeros[i].ToString("#0"));
            }

            Console.WriteLine("\n\nNúmeros em ordem inversa:\n");
            i = i - 1;

            while (i>=0)
            {
                Console.WriteLine("{0}", numeros[i].ToString("#0"));
                i--;
            }

            Console.ReadKey();
        }
    }
}
