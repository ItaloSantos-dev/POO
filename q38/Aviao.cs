using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q38
{
    internal class Aviao:Transporte
    {
        public int Altitude { get; set; }

        public override void Mover()
        {
            Console.WriteLine("Voando");
        }
    }
}
