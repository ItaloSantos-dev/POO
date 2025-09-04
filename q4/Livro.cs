using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Livro
    {
        public string titulo;
        public string autor;

        public string exibirInfo()
        {
            return "Titulo: " + titulo + " Autor: " + autor;
        }

    }
}
