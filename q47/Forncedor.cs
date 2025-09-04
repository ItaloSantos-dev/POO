using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q47
{
    internal class Fornecedor:Pessoa
    {
        public Fornecedor(string nome) : base(nome) { }
        public void Fornecer() => Console.WriteLine($"{Nome} está fornecendo.");
    }
}
