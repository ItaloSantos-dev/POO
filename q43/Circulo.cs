using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circulo:FormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
