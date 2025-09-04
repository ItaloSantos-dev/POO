using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q20
{
    internal class Jogo
    {
        public string Nome { get; set; }
        public string Plataforma { get; set; }

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }
        public void Jogar()
        {
            Console.WriteLine($"Você está jogando {Nome} na plataforma {Plataforma}!");
        }
    }
}
