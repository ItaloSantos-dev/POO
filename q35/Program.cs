using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca(1000);
            Console.WriteLine("Saldo inicial: " + cp.Saldo);
            cp.RenderJuros();
            Console.WriteLine("Saldo após juros: " + cp.Saldo);
        }
    }
}
