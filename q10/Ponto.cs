using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q10
{
    internal class Ponto
    {
        public double x;
        public double y;

        public double DistanciaOrigem()
        {
            return Math.Sqrt(x*x + y*y);
        }
    }
}
