using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q33
{
    internal class Quadrado:Forma
    {
        public double Lado { get; set; }
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;
        }

    }
}
