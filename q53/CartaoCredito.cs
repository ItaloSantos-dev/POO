using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q53
{
    internal class CartaoCredito:Pagamento
    {
        public override void Processar()
        {
            Console.WriteLine("Processando pagamento com cartão de crédito...");
        }
    }
}
