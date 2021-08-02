using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            char resp, inicio;
            double i, nota, n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, nfinal;
            i = 1;

        inicio:

            Console.Title = "Média While";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();


            Console.Write("Vamos calcular a média de cinco notas!");
            Console.Write("\n\nDigite seu nome: ");
            nome = Console.ReadLine();

            while (i<=5)
            {
                Console.Write("\nDigite a {0}º nota: ", i);
                nota = Double.Parse(Console.ReadLine());

                if (nota <= 10)
                {
                    if (nota >= 0)
                    {
                        if (i == 1)
                        {
                            n1 = nota;
                        }
                        if (i == 2)
                        {
                            n2 = nota;
                        }
                        if (i == 3)
                        {
                            n3 = nota;
                        }
                        if (i == 4)
                        {
                            n4 = nota;
                        }
                        if (i == 5)
                        {
                            n5 = nota;
                        }
                    }
                    else
                    {
                        Console.Write("\nNota inválida!");
                        Console.WriteLine("\nDeseja tentar novamente? s/n");
                        resp = char.Parse(Console.ReadLine());

                        if ((resp == 's' || (resp == 'S')))
                        {
                            goto inicio;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.Write("\nNota inválida!");
                    Console.WriteLine("\nDeseja tentar novamente? s/n");
                    resp = char.Parse(Console.ReadLine());

                    if ((resp == 's' || (resp == 'S')))
                    {
                        goto inicio;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                 i++;
            }

                nfinal = (n1 + n2 + n3 + n4 + n5) / 5;
                Console.WriteLine("\n{0} a sua média é {1}!", nome, nfinal);
                Console.WriteLine("\n Tentar novamente? s/n");
                resp = char.Parse(Console.ReadLine());

            if ((resp == 's' || (resp == 'S')))
            {
                goto inicio;
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
     
    }
}
