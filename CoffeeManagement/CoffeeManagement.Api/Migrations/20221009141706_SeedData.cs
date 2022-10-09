using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeManagement.Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Coffee" },
                    { 2, "FREEZE" },
                    { 3, "TEA" },
                    { 4, "BANH MI" }
                });

            migrationBuilder.InsertData(
                table: "TableFoods",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Table 01", 1 },
                    { 2, "Table 02", 1 },
                    { 3, "Table 03", 1 },
                    { 4, "Table 04", 1 },
                    { 5, "Table 05", 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodCategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Phin Sữa Đá", 29000m },
                    { 2, 1, "Phin Đen Đá", 29000m },
                    { 3, 2, "FREEZE Trà Xanh", 55000m },
                    { 4, 2, "FREEZE Chocolate", 55000m },
                    { 5, 3, "Trà Ổi Hồng", 45000m },
                    { 6, 3, "Trà Đào", 45000m },
                    { 7, 4, "Bánh Mì Gà", 29000m },
                    { 8, 4, "Bánh Mì Pate", 29000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TableFoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TableFoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TableFoods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TableFoods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TableFoods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
