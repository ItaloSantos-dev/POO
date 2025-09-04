using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente(5000, 2000);
            Console.WriteLine("Salário base: " + g.Salario);
            Console.WriteLine("Bônus: " + g.Bonus);
            Console.WriteLine("Salário total: " + g.CalcularSalarioTotal());
        }
    }
}
