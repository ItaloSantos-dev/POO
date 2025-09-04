using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("Italo", "@example.com");
            usuario.AlterarEmail("novoemail@example.com");


        }
    }
}
