using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>
            {
                new Mamifero(),
                new Ave()
            };

            foreach (var animal in animais)
            {
                animal.Comer();
            }
        }
    }
}
