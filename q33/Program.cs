using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            Console.WriteLine("Área do quadrado: " + quadrado.Area());
        }
    }
}
