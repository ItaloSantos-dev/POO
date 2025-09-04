using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q28
{
    internal class Forma
    {
        private double area;

        public Forma(double largura, double altura)
        {
            area = largura * altura; 
        }
        public double Area
        {
            get { return area; }
        }


    }

}
