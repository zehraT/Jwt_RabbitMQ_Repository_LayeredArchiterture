using RabbitMQ.Client;

namespace FinalExamTest.RabbitMQ
{
    public class ConnectionHelper
    {
        public IConnection Connection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            return connectionFactory.CreateConnection();
        }
    }
}
