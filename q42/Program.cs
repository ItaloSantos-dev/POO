using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado h = new Horista(160, 50);
            Empregado a = new Assalariado(5000);

            Console.WriteLine("Salário Horista: " + h.CalcularSalario());
            Console.WriteLine("Salário Assalariado: " + a.CalcularSalario());
        }
    }
}
