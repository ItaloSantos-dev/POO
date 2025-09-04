using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    internal class ProdutoFisico:Produto
    {
        public double Frete { get; set; }

        public ProdutoFisico(double precoBase, double frete) : base(precoBase)
        {
            Frete = frete;
        }

        public override double CalcularPreco()
        {
            return PrecoBase + Frete;
        }
    }
}
