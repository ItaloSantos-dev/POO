using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    internal class ProdutoServico:Produto
    {
        public double Taxa { get; set; }
        public ProdutoServico(double precoBase, double taxa) : base(precoBase)
        {
            Taxa = taxa;
        }
        public override double CalcularPreco()
        {
            return PrecoBase + Taxa;
        }
    }
}
