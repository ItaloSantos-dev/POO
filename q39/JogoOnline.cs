using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q39
{
    internal class JogoOnline:Jogo
    {
        public string Servidor { get; set; }
        public JogoOnline(string nome, string servidor) : base(nome)
        {
            Servidor = servidor;
        }
        public void Conectar()
        {
            Console.WriteLine($"Conectando ao servidor {Servidor}...");
        }
    }
}
