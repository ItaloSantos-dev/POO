using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q54
{
    internal class Engenheiro:Funcionario
    {
        public double Salario { get; set; }

        public Engenheiro(double salario)
        {
            Salario = salario;
        }

        public override double CalcularBonus()
        {
            return 1000; 
        }
    }
}
