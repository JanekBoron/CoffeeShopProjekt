using System;
using CoffeeShop.Database.DbUp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoffeeShop.Database.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDatabaseDbUp();
                    services.AddHostedService<MigratorRunner>();
                })
                .RunConsoleAsync();
        }
    }
}