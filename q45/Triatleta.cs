using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q45
{
    interface INadador
    {
        void Nadar();
    }

    interface ICorredor
    {
        void Correr();
    }
    internal class Triatleta
    {
        

       
            public void Nadar() => Console.WriteLine("Triatleta nadando...");
            public void Correr() => Console.WriteLine("Triatleta correndo...");
            public void Competir() => Console.WriteLine("Triatleta competindo!");
        
    }
}
