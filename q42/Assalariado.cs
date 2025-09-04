using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q42
{
    internal class Assalariado:Empregado
    {
        public double SalarioFixo { get; set; }

        public Assalariado(double salarioFixo)
        {
            SalarioFixo = salarioFixo;
        }

        public override double CalcularSalario()
        {
            return SalarioFixo;
        }
    }
}
