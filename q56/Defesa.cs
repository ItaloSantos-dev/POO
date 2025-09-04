using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q56
{
    internal class Defesa:Estrategia
    {
        public override void Executar()
        {
            Console.WriteLine("Executando defesa!");
        }
    }
}
