using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.titulo = "linguagem c completa e descomplicada";
            livro.autor = "ANDRÉ BACKES";
            Console.WriteLine("Titulo: " + livro.titulo);
            Console.WriteLine("Autor: " + livro.autor);
        }
    }
}
