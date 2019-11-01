using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace FinalExamTest.RabbitMQ
{
    public class ConsumerHelper
    {
        public ConsumerHelper(string queueName)
        {
            IConnection connection = new ConnectionHelper().Connection();
            IModel model = connection.CreateModel();
            EventingBasicConsumer eventingBasicConsumer = new EventingBasicConsumer(model);
            eventingBasicConsumer.Received += (sender, args) =>
            {
                byte[] body = args.Body;
                string message = Encoding.UTF8.GetString(body);
                if (message != "")
                {
                    Console.WriteLine("RECEIVE: " + queueName + ", Message: " + message + ", Second: " + DateTime.Now.Second);
                }
            };

            model.BasicConsume(queueName, false, eventingBasicConsumer);
        }
    }
}
