using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQConsumer
{
    public class Consumer
    {
        private RabbitMQService _rabbitMQService;

        public Consumer(string queueName)
        {
            _rabbitMQService = new RabbitMQService();
            while (true)
            {
                using (var connection = _rabbitMQService.GetRabbitMQConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare(queueName, false, false, false, null);
                        var consumer = new EventingBasicConsumer(channel);
                        BasicGetResult result = channel.BasicGet(queueName, true);
                        if (result != null)
                        {
                            string data =
                            Encoding.UTF8.GetString(result.Body);
                            Console.WriteLine(data);
                        }
                    }
                }
            }
          
        }
    }
}
