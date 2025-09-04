using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q40
{
    internal class Revista:BibliotecaItem
    {
        public int Edicao { get; set; }
        public Revista(string titulo, int edicao) : base(titulo)
        {
            Edicao = edicao;
        }
    }
}
