using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q47
{
    internal class Cliente:Pessoa
    {
        public Cliente(string nome) : base(nome) { }
        public void Comprar() => Console.WriteLine($"{Nome} está comprando.");
    }
}
