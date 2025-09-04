using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q48
{
    internal class Arquivo
    {
        public string Nome { get; set; }
        public Arquivo(string nome) { Nome = nome; }
        public virtual void Abrir() => Console.WriteLine($"Abrindo arquivo {Nome}...");
    }
}
