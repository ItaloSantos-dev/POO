using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q42
{
    internal class Horista:Empregado
    {
        public double Horas { get; set; }
        public double Taxa { get; set; }
   
        public Horista(double horas, double taxa)
        {
            Horas = horas;
            Taxa = taxa;
        }

        public override double CalcularSalario()
        {
            return Horas * Taxa;
        }
    }
}
