using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.Database.DbUp
{
    public static class DependencyInjection
    {
        public static void AddDatabaseDbUp(this IServiceCollection services)
        {
            services.AddScoped<IMigrator, DbUpMigrator>();
        }
    }
}