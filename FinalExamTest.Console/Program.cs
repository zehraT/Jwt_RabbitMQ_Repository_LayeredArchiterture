using FinalExamTest.RabbitMQ;
using System;

namespace FinalExamTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new PublisherHelper("userLog", "");
            new ConsumerHelper("userLog");
        }
    }
}
