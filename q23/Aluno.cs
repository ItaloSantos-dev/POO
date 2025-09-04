using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q23
{
    internal class Aluno
    {
        private float nota;

        public float Nota
        {
            get => nota;

            set
            {
                if(value>=0 && value < 10)
                {
                    nota = value;
                    Console.WriteLine("nota alterada com sucesso");

                }
                else
                {
                    Console.WriteLine("Digite uma nota válida");
                }


            }
        }
                

    }
}
