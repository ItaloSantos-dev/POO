using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Retangulo:FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
