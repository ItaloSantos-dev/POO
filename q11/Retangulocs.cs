using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    internal class Retangulo
    {
        public float Altura { get; set; }
        public float Largura { get; set; }

        public Retangulo(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public float Area()
        {
            return Altura * Largura;
        }
    }
}
