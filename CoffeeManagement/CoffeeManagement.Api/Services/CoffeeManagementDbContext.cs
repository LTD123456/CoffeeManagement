using CoffeeManagement.Api.DataModel;
using CoffeeManagement.Api.Extensions.DataModel;
using CoffeeManagement.Api.Services.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CoffeeManagement.Api.Services;

public sealed class CoffeeManagementDbContext : DbContext
{
    public CoffeeManagementDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Account> Accounts { get; set; } = null!;
    public DbSet<Bill> Bills { get; set; } = null!;
    public DbSet<BillInfo> BillInfos { get; set; } = null!;
    public DbSet<Food> Foods { get; set; } = null!;
    public DbSet<FoodCategory> FoodCategories { get; set; } = null!;
    public DbSet<TableFood> TableFoods { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new BillConfiguration());
        modelBuilder.ApplyConfiguration(new BillInfoConfiguration());
        modelBuilder.ApplyConfiguration(new FoodCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FoodConfiguration());

        modelBuilder.Seed();
    }
}
