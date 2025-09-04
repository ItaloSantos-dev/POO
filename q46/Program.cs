using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new ProdutoFisico(100, 20);
            Produto p2 = new ProdutoServico(200, 50);

            Console.WriteLine("Preço produto físico: " + p1.CalcularPreco());
            Console.WriteLine("Preço produto serviço: " + p2.CalcularPreco());
        }
    }
}
