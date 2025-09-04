using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q53
{
    internal class Boleto:Pagamento
    {
        public override void Processar()
        {
            Console.WriteLine("Processando pagamento com boleto...");
        }
    }
}
