using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace q10
{
    internal class Program
    {
        static void Main(string[] args)
        {   Ponto ponto = new Ponto();

            Console.WriteLine("Digite o ponto x do plano cartesiano");
            ponto.x=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ponto y do plano cartesiano");
            ponto.y = double.Parse(Console.ReadLine());

            double resultado = ponto.DistanciaOrigem();
            Console.WriteLine("Este é o resultado: " + resultado);



        }
    }
}
