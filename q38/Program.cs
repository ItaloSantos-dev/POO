using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aviao a = new Aviao();
            a.Altitude = 10000;
            a.Mover();
            Console.WriteLine("Altitude: " + a.Altitude + " pés");
        }
    }
}
