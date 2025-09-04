using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormaGeometrica[] formas = { new Retangulo(4, 6), new Circulo(3) };
            foreach (var forma in formas)
            {
                Console.WriteLine("Perímetro: " + forma.Perimetro());
            }
        }
    }
}
