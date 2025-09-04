using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            float soma =calculadora.somar(5, 2);
            float subtrair = calculadora.subtrair(5, 2);
            float multiplicar = calculadora.multiplicar(5, 2);
            float dividir = calculadora.dividir(5, 2);
            Console.WriteLine("Soma: " + soma + " subtração: " + subtrair + " multiplicação: " + multiplicar + " dividisão: " + dividir);
        }
    }
}
