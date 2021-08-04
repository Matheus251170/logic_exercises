using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioMinimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double sal_minimo;
            double[] salarios = new double[10];

            Console.Write("Insira seu salário: ");
            sal_minimo = Convert.ToDouble(Console.ReadLine());

                for (i = 0; i < salarios.Length; i++)
                salarios[i] = (i + 1) * sal_minimo;
            
            for (i = 0; i < salarios.Length; i++)
                Console.WriteLine("\n{0} Salário(s) Minimo(s) = {1}", (i + 1), salarios[i].ToString("#00.00"));

            Console.ReadKey();
        }
    }
}
