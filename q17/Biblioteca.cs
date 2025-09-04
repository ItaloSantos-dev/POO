using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    internal class Biblioteca
    {

        private List<string> livros;
        public Biblioteca()
        {
            livros = new List<string>();
        }

        public void AdicionarLivro(string titulo)
        {
            livros.Add(titulo);
            Console.WriteLine("Livro adicionado à biblioteca.");
        }
    }
}
