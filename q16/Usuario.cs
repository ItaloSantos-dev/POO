using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q16
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; private set; }
        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void AlterarEmail(string novoEmail)
        {
            Email = novoEmail;
            Console.WriteLine($"Email alterado para: {Email}");
        }
    }
}
