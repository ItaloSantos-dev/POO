using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AdicionarLivro("O Senhor dos Anéis");
            biblioteca.AdicionarLivro("Harry Potter");

        }
    }
}
