using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q19
{
    internal class Agenda
    {
        private List<string> contatos;

        public Agenda(List<string> contatos)
        {
            this.contatos = contatos;
        }
        public string BuscarContato(string nome)
        {
            foreach (string contato in contatos)
            {
                if (contato.Equals(nome))
                {
                    return contato;
                }
            }
            return "Contato não encontrado";
        }

    }
    }

