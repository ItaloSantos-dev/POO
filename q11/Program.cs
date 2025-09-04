using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo(5.0f, 3.0f);
            Console.WriteLine("Área do retângulo: " + ret.Area());

        }
    }
}
