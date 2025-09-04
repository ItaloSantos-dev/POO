using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q54
{
    internal class Vendedor:Funcionario
    {
        public double Vendas { get; set; }

        public Vendedor(double vendas)
        {
            Vendas = vendas;
        }

        public override double CalcularBonus()
        {
            return Vendas * 0.10; 
        }
    }
}
