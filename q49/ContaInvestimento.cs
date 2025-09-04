using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q49
{
    internal class ContaInvestimento:ContaBancaria
    {
        public ContaInvestimento(double saldo) : base(saldo) { }
        public override void Sacar(double valor)
        {
            if (Saldo >= valor) { Saldo -= valor; Console.WriteLine($"Saque {valor}. Saldo: {Saldo}"); }
            else Console.WriteLine("Saldo insuficiente!");
        }
        public void Render() { Saldo *= 1.05; Console.WriteLine("Rendimento aplicado! Saldo: " + Saldo); }
    }
}
