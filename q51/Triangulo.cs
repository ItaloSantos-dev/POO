using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q51
{
    internal class Triangulo:Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public override double Area()
        {
            return (Base * Altura) / 2;
        }
    }
}
