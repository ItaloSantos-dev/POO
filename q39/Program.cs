using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoOnline jogo = new JogoOnline("Fifa", "BR");
            Console.WriteLine("Jogo: " + jogo.Nome);
            jogo.Conectar();
        }
    }
}
