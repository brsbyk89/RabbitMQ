﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuyruktan veriler sirasi ile çekilecektir.....");
            var consumer = new Consumer("MailQueue");
        }
    }
}
