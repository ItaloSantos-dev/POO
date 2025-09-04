using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemMenu prato = new PratoPrincipal();
            ItemMenu sobremesa = new Sobremesa();

            prato.Preparar();
            sobremesa.Preparar();
        }
    }
}
