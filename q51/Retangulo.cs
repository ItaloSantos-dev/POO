using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q51
{
    internal class Retangulo:Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double l, double h)
        {
            Largura = l;
            Altura = h;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
