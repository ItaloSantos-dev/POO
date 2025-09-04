using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            circulo.raio = float.Parse( Console.ReadLine());
            float area =circulo.Area();
            float perimetro = circulo.Perimetro();
            Console.WriteLine("Area: " + area + " Perimetro: " + perimetro );
        }
    }
}
