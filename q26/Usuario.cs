using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q26
{
    internal class Usuario
    {
        private string senha="152";
        public void Autenticar(string _senha)
        {
            if (_senha.Equals(senha) ){
                Console.WriteLine("Senha correta");
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }

        }
    }
}
