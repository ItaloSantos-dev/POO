using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q29
{
    internal class Empregado
    {
        private double salario;

        public Empregado(double salario)
        {
            this.salario = salario;
        }
        public double CalcularBonus()
        {
            return salario * 0.10;
        }
    }
}
