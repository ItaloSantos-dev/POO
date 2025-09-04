using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q25
{
    internal class Carro
    {
        private int velociadade;
        public void acelerar (int incremento)
        {
            if (velociadade + incremento > 200)
            {
                Console.WriteLine("Digite um incremento menor");
            }
            else
            {
                velociadade += incremento;
                Console.WriteLine("Sua nova velocidade é: " + velociadade);
            }
        }
    }
}
