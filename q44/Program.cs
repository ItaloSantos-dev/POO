using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Bicicleta();
            Veiculo v2 = new Moto();

            v1.Acelerar();
            v2.Acelerar();
        }
    }
}
