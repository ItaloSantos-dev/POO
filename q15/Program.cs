using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(3, 4, 5);

            // Chamando o método Perimetro
            Console.WriteLine("Perímetro do triângulo: " + t.Perimetro());


        }
    }
}
