using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Relatorio pdf = new RelatorioPDF();
            Relatorio excel = new RelatorioExcel();

            pdf.Gerar();
            excel.Gerar();
        }
    }
}
