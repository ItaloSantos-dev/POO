using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q35
{
    internal class Conta
    {
        public double Saldo { get; protected set; }
        public Conta(double saldoInicial)
        {
            Saldo = saldoInicial;
        }
    }
}
