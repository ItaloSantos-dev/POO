using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo1 = new Jogo("Zelda", "Nintendo ");
            jogo1.Jogar();

            Jogo jogo2 = new Jogo("FIFA ", "Play 5");
            jogo2.Jogar();
        }
    }
}
