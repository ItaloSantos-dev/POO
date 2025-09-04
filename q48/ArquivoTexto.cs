using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q48
{
    internal class ArquivoTexto:Arquivo
    {
        public int Tamanho { get; set; }
        public ArquivoTexto(string nome, int tamanho) : base(nome) { Tamanho = tamanho; }
        public override void Abrir()
        {
            if (Tamanho < 1000) Console.WriteLine($"Abrindo texto {Nome}...");
            else Console.WriteLine($"Arquivo de texto {Nome} muito grande!");
        }
    }
}
