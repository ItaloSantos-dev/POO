using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q48
{
    internal class ArquivoBinario:Arquivo
    {
        public int Tamanho { get; set; }
        public ArquivoBinario(string nome, int tamanho) : base(nome) { Tamanho = tamanho; }
        public override void Abrir()
        {
            if (Tamanho < 5000) Console.WriteLine($"Abrindo binário {Nome}...");
            else Console.WriteLine($"Arquivo binário {Nome} muito grande!");
        }
    }
}
