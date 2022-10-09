using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeManagement.Api.Services;

public class CoffeeManagementDbContextFactory : IDesignTimeDbContextFactory<CoffeeManagementDbContext>
{
    public CoffeeManagementDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        var connectionString = configuration.GetConnectionString("coffeeManagementDb");

        var optionsBuilder = new DbContextOptionsBuilder<CoffeeManagementDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new CoffeeManagementDbContext(optionsBuilder.Options);
    }
}
