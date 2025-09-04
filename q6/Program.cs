using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "João";
            a1.nota = 5.5f;

            Aluno a2 = new Aluno();
            a2.nome = "José";
            a2.nota = 7.5f;

            if(a1.nota>a2.nota)
            {
                Console.WriteLine("O aluno " + a1.nome + " tirou uma nota maior que o aluno " + a2.nome);
            }
            else
            {
                Console.WriteLine("O aluno " + a2.nome + " tirou uma nota maior que o aluno " + a1.nome);

            }


        }
    }
}
