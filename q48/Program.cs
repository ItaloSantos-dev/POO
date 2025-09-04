using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arquivo a1 = new ArquivoTexto("doc.txt", 800);
            Arquivo a2 = new ArquivoBinario("video.mp4", 10000);

            a1.Abrir();
            a2.Abrir();
        }
    }
}
