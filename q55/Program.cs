using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo eletrico = new CarroEletrico(10); // 10 km/kWh
            Veiculo gasolina = new CarroGasolina(12); // 12 km/l

            eletrico.Viajar(50);
            gasolina.Viajar(50);
        }
    }
}
