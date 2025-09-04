using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q57
{
    internal class RelatorioPDF:Relatorio
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerando relatório em PDF...");
        }
    }
}
