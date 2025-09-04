using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro("Clean Code", "Robert C. Martin");
            Revista r = new Revista("Ciência Hoje", 120);

            Console.WriteLine($"Livro: {l.Titulo}, Autor: {l.Autor}");
            Console.WriteLine($"Revista: {r.Titulo}, Edição: {r.Edicao}");
        }
    }
}
