using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q37
{
    internal class ProdutoDigital:Produto
    {
        public double TamanhoArquivo { get; set; } 
        public ProdutoDigital(double preco, double tamanhoArquivo) : base(preco)
        {
            TamanhoArquivo = tamanhoArquivo;
        }

        public void Baixar()
        {
            Console.WriteLine($"Baixando arquivo de {TamanhoArquivo} MB...");
        }
    }
}
