using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal peixe = new Peixe();
            Animal passaro = new Passaro();

            peixe.Mover();
            passaro.Mover();
        }
    }
}
