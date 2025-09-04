using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Carlos";
            a.Idade = 20;
            a.Nota = 8.5;

            Console.WriteLine($"Aluno: {a.Nome}, Idade: {a.Idade}, Nota: {a.Nota}");
            a.Estudar();
        }
    }
}
