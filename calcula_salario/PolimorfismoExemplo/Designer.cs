using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoExemplo
{
    class Designer : Funcionario
    {

        public override void Rejustar()
        {
            salario += 500;
        }
    }
}
