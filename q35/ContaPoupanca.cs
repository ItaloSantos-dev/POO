using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q35
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(double saldoInicial) : base(saldoInicial) { }

        public void RenderJuros()
        {
            Saldo += Saldo * 0.01;
        }
    }
}
