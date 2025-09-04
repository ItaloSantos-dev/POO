using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q55
{
    internal class CarroEletrico:Veiculo
    {
        public double Autonomia { get; set; } 

        public CarroEletrico(double autonomia)
        {
            Autonomia = autonomia;
        }

        public override double CalcularCombustivel(double km)
        {
            return km / Autonomia;
        }

        public override void Viajar(double km)
        {
            Console.WriteLine($"Carro elétrico viajou {km} km usando {CalcularCombustivel(km)} kWh.");
        }
    }
}
