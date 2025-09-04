using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    internal class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }
        public double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
