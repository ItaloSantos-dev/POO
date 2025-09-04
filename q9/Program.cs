using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.AplicarDesconto();
           Console.WriteLine("O valor do produto com desconto é: "+produto.preco);
        }
    }
}
