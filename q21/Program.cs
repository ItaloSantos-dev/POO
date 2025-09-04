using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Digite uma nova idade");
            p1.Idade=int.Parse(Console.ReadLine());
            Console.WriteLine("A idade da pessoa agora é: "+p1.Idade);
        }
    }
}
