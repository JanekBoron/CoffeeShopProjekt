namespace CoffeeShop.Database
{
    public interface IMigrator
    {
        void Execute(string connectionString);
    }

}