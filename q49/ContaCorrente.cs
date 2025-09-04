using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q49
{
    internal class ContaCorrente:ContaBancaria
    {
        public double Limite { get; set; }
        public ContaCorrente(double saldo, double limite) : base(saldo) { Limite = limite; }
        public override void Sacar(double valor)
        {
            if (Saldo + Limite >= valor) { Saldo -= valor; Console.WriteLine($"Saque {valor}. Saldo: {Saldo}"); }
            else Console.WriteLine("Saldo insuficiente!");
        }
    }
}
