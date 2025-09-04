using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            if (pessoa!=null)
            {
                Console.WriteLine("Voce instanciou um objeto da classe pessoa");
            }
        }
    }
}
