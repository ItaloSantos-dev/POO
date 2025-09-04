using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q46
{
    internal class Produto
    {
        public double PrecoBase { get; set; }

        public Produto(double precoBase)
        {
            PrecoBase = precoBase;
        }

        public virtual double CalcularPreco()
        {
            return PrecoBase;
        }
    }
}
