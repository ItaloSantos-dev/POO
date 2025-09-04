using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.nome = "Gorila";
            animal.idade = 18;
            Console.WriteLine(animal.nome + " tem " + animal.idade + " anos");
        }
    }
}
