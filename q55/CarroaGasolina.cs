using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q55
{
    internal class CarroGasolina:Veiculo
    {
        public double Consumo { get; set; } 
        public CarroGasolina(double consumo)
        {
            Consumo = consumo;
        }

        public override double CalcularCombustivel(double km)
        {
            return km / Consumo;
        }

        public override void Viajar(double km)
        {
            Console.WriteLine($"Carro a gasolina viajou {km} km usando {CalcularCombustivel(km)} litros.");
        }
    }
}
