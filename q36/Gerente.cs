using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q36
{
    internal class Gerente: Funcionario
    {
        public double Bonus { get; set; }

        public Gerente(double salario, double bonus) : base(salario)
        {
            Bonus = bonus;
        }

        public double CalcularSalarioTotal()
        {
            return Salario + Bonus;
        }
    }
}
