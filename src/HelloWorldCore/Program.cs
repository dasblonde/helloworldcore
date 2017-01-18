using Serilog;
using Serilog.Sinks.Elasticsearch;
using System;

namespace HelloWorldCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("foo");

            var log = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://dockervraposo.cloudapp.net:9200"))
                {
                    AutoRegisterTemplate = true
                })
                .CreateLogger();

            log.Information("hello world from asp.net");
        }
    }
}
