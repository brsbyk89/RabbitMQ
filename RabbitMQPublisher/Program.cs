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
            var publisher = new Publisher();

            publisher.SendToRabbitMQ("MailQueue", "kuyruğa attığım üçüncü mesaj");

            Console.ReadLine();
        }
    }
}
