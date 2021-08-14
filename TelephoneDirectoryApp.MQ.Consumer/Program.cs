using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using TelephoneDirectoryApp.Data.DataContext;
using TelephoneDirectoryApp.Data.Repository;
using TelephoneDirectoryApp.Manager.WebManager;

namespace TelephoneDirectoryApp.MQ.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                 .AddEntityFrameworkNpgsql().AddDbContext<ProjectDbContext>(opt =>
        opt.UseNpgsql("User ID =kimopostgres;Password=Pa22w0rd*;Server=192.168.2.109;Port=4000;Database=TestDb;Integrated Security=true;Pooling=true;"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IReportManager, ReportManager>()
                .BuildServiceProvider();


            var reportManager = serviceProvider.GetService<IReportManager>();
            //var test = reportManager.GetAllActiveReport();

            var factory = new ConnectionFactory() { HostName = "127.0.0.1" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "reportQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" Received {0}", message);
                    var result = reportManager.CalculateReportForResult(new Guid(message));
                    Console.WriteLine(" Calculating Result {0}", result);

                };
                channel.BasicConsume(queue: "reportQueue",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
