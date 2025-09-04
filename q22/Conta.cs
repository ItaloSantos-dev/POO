using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22
{
    internal class Conta
    {
        private float saldo =1000;

        public float Saldo { get => saldo; set => saldo = value; }
        public void Depositar(float valor)
        {
            saldo += valor;
            Console.WriteLine("Valor depositado com sucesso");
        }
        public void Scar(float valor)
        {
            if (saldo > valor)
            {
                saldo-=valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

    }
}
