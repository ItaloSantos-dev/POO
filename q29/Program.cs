using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado emp = new Empregado(5000);
            Console.WriteLine("Bônus do empregado: " + emp.CalcularBonus());
        }
    }
}
