using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q59
{
    internal class SmsNotificador:Notificador
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }
}
