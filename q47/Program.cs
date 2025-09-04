using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Cliente("Maria"),
                new Fornecedor("João")
            };

            foreach (var p in pessoas)
            {
                if (p is Cliente c) c.Comprar();
                if (p is Fornecedor f) f.Fornecer();
            }
        }
    }
}
