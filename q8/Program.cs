using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            float valoradd = float.Parse(Console.ReadLine());
            contaBancaria.Depositar(valoradd);
            Console.WriteLine("O saldo atual é: "+ contaBancaria.saldo);
        }
    }
}
