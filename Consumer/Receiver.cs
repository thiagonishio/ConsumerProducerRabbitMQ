using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Consumer
{
    class Receiver
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    // para RabbitMQ.Client 5.1.2 ou anterior
                    //var body = ea.Body.Span;
                    //var message = Encoding.UTF8.GetBytes(body);
                    
                    var body = ea.Body.Span;                    
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine("Received message {0}...", message);
                };

                channel.BasicConsume("BasicTest", true, consumer);

                Console.WriteLine("Press [Enter] to exit the Consumer...");
                Console.ReadLine();
            }

            
        }
    }
}
