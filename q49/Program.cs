using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(500, 200);
            cc.Sacar(600);

            ContaInvestimento ci = new ContaInvestimento(1000);
            ci.Render();
            ci.Sacar(200);
        }
    }
}
