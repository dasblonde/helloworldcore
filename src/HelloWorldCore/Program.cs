using Serilog;
using Serilog.Sinks.Elasticsearch;
using System;

namespace HelloWorldCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri("http://[dockerhost]:9200"))
                {
                    AutoRegisterTemplate = true
                })
                .CreateLogger();

            log.Information("hello world from asp.net");
        }
    }
}
