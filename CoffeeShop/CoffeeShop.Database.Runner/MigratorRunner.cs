using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace CoffeeShop.Database.Runner
{
    public class MigratorRunner : IHostedService
    {
        private readonly IMigrator _migrator;
        private readonly IConfiguration _configuration;

        public MigratorRunner(IMigrator migrator, IConfiguration configuration)
        {
            _migrator = migrator;
            _configuration = configuration;
        }

        public Task StartAsync(CancellationToken cancellationToken) =>
            Task.Run(() => _migrator.Execute(_configuration["DatabaseModuleConnectionString"]), cancellationToken);

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}