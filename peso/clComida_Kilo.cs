using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento18092020
{
    class clComida_Kilo
    {
        private double pPrato = 35;
        private double pMarmitex = 30;

        public double CalcularPrecoFinal(double peso, int tipo)
        {
            double precofinal;

            if (tipo == 1)
            {
                precofinal = (pPrato/1000)*peso;
            }
            else if (tipo == 2)
            {
                precofinal = (pMarmitex / 1000) * peso;
            }
            else
            {
                precofinal = 0;
            }

            return precofinal;
            
        }


    }
}
