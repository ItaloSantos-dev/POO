using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q8
{
    internal class ContaBancaria
    {
        public float saldo = 0;
        
        public void Depositar (float _valoradd)
        {
            saldo += _valoradd;
        }
    }
}
