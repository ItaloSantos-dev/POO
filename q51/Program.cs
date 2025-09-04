using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma t = new Triangulo(5, 3);
            Forma r = new Retangulo(4, 6);

            Console.WriteLine($"Área do Triângulo: {t.Area()}");
            Console.WriteLine($"Área do Retângulo: {r.Area()}");
        }
    }
}
