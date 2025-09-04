using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoDigital pd = new ProdutoDigital(99.90, 250);
            Console.WriteLine("Preço: " + pd.Preco);
            pd.Baixar();
        }
    }
}
