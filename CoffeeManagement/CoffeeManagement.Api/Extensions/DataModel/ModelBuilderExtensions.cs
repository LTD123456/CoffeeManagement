using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;

namespace CoffeeManagement.Api.Extensions.DataModel;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TableFood>().HasData(
            new TableFood { Id = 1, Name = "Table 01", Status = TableFoodStatus.Available },
            new TableFood { Id = 2, Name = "Table 02", Status = TableFoodStatus.Available },
            new TableFood { Id = 3, Name = "Table 03", Status = TableFoodStatus.Available },
            new TableFood { Id = 4, Name = "Table 04", Status = TableFoodStatus.Available },
            new TableFood { Id = 5, Name = "Table 05", Status = TableFoodStatus.Available }
        );

        modelBuilder.Entity<FoodCategory>().HasData(
            new FoodCategory { Id = 1, Name = "Coffee" },
            new FoodCategory { Id = 2, Name = "FREEZE" },
            new FoodCategory { Id = 3, Name = "TEA" },
            new FoodCategory { Id = 4, Name = "BANH MI" }
        );

        modelBuilder.Entity<Food>().HasData(
            new Food { Id = 1, FoodCategoryId = 1, Name = "Phin Sữa Đá", Price = 29000 },
            new Food { Id = 2, FoodCategoryId = 1, Name = "Phin Đen Đá", Price = 29000 },
            new Food { Id = 3, FoodCategoryId = 2, Name = "FREEZE Trà Xanh", Price = 55000 },
            new Food { Id = 4, FoodCategoryId = 2, Name = "FREEZE Chocolate", Price = 55000 },
            new Food { Id = 5, FoodCategoryId = 3, Name = "Trà Ổi Hồng", Price = 45000 },
            new Food { Id = 6, FoodCategoryId = 3, Name = "Trà Đào", Price = 45000 },
            new Food { Id = 7, FoodCategoryId = 4, Name = "Bánh Mì Gà", Price = 29000 },
            new Food { Id = 8, FoodCategoryId = 4, Name = "Bánh Mì Pate", Price = 29000}
        );
    }
}
