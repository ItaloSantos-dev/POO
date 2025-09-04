using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q27
{
    internal class Banco
    {
        private List<int> IDs = new List<int>();
        

        public void Adicionar(int id)
        {
            IDs.Add(id);
            Console.WriteLine("Adicionado com sucesso");
        }
        public void remover(int id) 
        {
            IDs.Remove(id);
            Console.WriteLine("Removido com sucesso");
        }
    }
}
