﻿using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCommon
{
    public class RabbitMQService
    {
        public RabbitMQService()
        {

        }
        // localhost üzerinde kurulu olduğu için host adresi olarak bunu kullanıyorum.
        private readonly string _hostName = "localhost";

        public IConnection GetRabbitMQConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                // RabbitMQ'nun bağlantı kuracağı host'u tanımlıyoruz. Herhangi bir güvenlik önlemi koymak istersek, Management ekranından password adımlarını tanımlayıp factory içerisindeki "UserName" ve "Password" property'lerini set etmemiz yeterlidir.
                HostName = _hostName
            };

            return connectionFactory.CreateConnection();
        }
    }
}
