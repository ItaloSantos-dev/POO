using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q24
{
    internal class Produto
    {
        private float preco=1000;

        public void Desconto (int desconto)
        {
            float result = preco-(preco*((float)desconto/100));
            if (result < 0)
            {
                Console.WriteLine("Digite um desconto valido");
            }
            else
            {
                preco = result;
                Console.WriteLine("Desconto aplicado com sucesso");
                Console.WriteLine("Novo preco: "+ preco);
            }

        }
    }
}
