using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string> { "Italo", "Maria", "João" };

            Agenda agenda = new Agenda(lista);

            Console.WriteLine(agenda.BuscarContato("Maria"));
            Console.WriteLine(agenda.BuscarContato("Pedro"));
        }
    }
}
