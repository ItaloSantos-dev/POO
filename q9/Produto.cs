using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9
{
    internal class Produto
    {
        public string nome = "arroz";
        public float preco = 3.5f;//faz o l
    
        public void AplicarDesconto ()
        {
            preco = preco * 0.9f;
        }

    }
}
