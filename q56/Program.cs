using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estrategia ataque = new Ataque();
            Estrategia defesa = new Defesa();

            ataque.Executar();
            defesa.Executar();
        }
    }
}
