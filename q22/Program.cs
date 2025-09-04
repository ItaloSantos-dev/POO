using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Console.WriteLine("Saldo atual: " + conta.Saldo);
            
            conta.Depositar(1250);
            Console.WriteLine("Saldo atual: " + conta.Saldo);
            conta.Scar(2500);
            
        }
    }
}
