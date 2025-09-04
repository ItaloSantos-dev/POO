using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q55
{
    abstract class Veiculo
    {
        public abstract double CalcularCombustivel(double km);
        public abstract void Viajar(double km);
    }
}
