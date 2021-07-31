using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoExemplo
{
    class Programador: Funcionario
    {

        public override void Rejustar()
        {
            salario += 1000;
        }

    }
}
