using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Funcionario funcionario = new Funcionario("Italo", 2000);

            funcionario.AumentarSalario(10); 
            Console.WriteLine("Novo salário:" + funcionario.Salario);
            


        }
    }
}
