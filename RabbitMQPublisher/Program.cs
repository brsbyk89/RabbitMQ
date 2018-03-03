using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("MailQueue eklemek istediğiniz mesajı giriniz. Çıkış için Exit yazınız");

                var message = Console.ReadLine();

                if (message.ToLower() == "exit")
                {
                    break;
                }

                var publisher = new Publisher();

                publisher.SendToRabbitMQ("MailQueue", message);
            
            }

        }
    }
}
