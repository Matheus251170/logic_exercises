using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dificil
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, z =  0, y = 0, lim, x, par = 0, imp = 0;
            char resp, inicio;

        inicio:

            Console.Title = "Par e Impar While";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.Write("Digite a quantidade de números que você deseja: ");
            lim = int.Parse(Console.ReadLine());
            x = 1;

            while (x <= lim)
            {

                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                x++;

               
                if (n < 0)
                {
                    z++;
                }
                else 
                {
                    y++;
                }
                if (n % 2 != 0)
                {
                    imp++;
                }
                else
                {
                    par++;
                }
                
            }

            Console.WriteLine("\nNúmeros impares: {0}", imp++);
            Console.WriteLine("\nNúmeros pares: {0}", par++);

            Console.Write("Deseja encerrar o programa? Se sim digite 's', se não digite n: ");
            resp = char.Parse(Console.ReadLine());
            if ((resp == 'n' || (resp == 'N')))
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("O Programa será fechado!");
                Environment.Exit(0);
            }
        }
    }
}
