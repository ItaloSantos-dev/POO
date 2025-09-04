using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando o " + Marca);
        }
    }
}
