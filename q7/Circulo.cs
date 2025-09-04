using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Circulo
    {
        public float raio;
        public float Area()
        {
            return (float) (raio*raio*Math.PI);

        }

        public float Perimetro()
        {
            return (float) (2*Math.PI*raio);
        }
    }
}
