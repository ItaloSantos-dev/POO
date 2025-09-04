using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificador email = new EmailNotificado();
            Notificador sms = new SmsNotificador();

            email.Enviar("Olá, você recebeu um email!");
            sms.Enviar("Olá, você recebeu um SMS!");
        }
    }
}
