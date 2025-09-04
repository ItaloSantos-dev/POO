using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q49
{
    internal class ContaBancaria
    {
        public double Saldo { get; protected set; }
        public ContaBancaria(double saldo) { Saldo = saldo; }
        public virtual void Sacar(double valor) => Console.WriteLine("Saque genérico");
    }
}
