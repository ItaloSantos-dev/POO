using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento cartao = new CartaoCredito();
            Pagamento boleto = new Boleto();

            cartao.Processar();
            boleto.Processar();
        }

    }
    }

