using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q34
{
    internal class Aluno:Pessoa
    {
        public double Nota { get; set; }

        public void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando ");
        }
    }
}
