using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q40
{
    internal class Livro:BibliotecaItem
    {
        public string Autor { get; set; }

        public Livro(string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }
    }
}
