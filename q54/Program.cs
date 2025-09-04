using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario vendedor = new Vendedor(5000);
            Funcionario engenheiro = new Engenheiro(7000);

            Console.WriteLine($"Bônus do Vendedor: {vendedor.CalcularBonus()}");
            Console.WriteLine($"Bônus do Engenheiro: {engenheiro.CalcularBonus()}");
        }
    }
}
