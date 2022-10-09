using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class Food
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Decimal? Price { get; set; } = 0;

    public int FoodCategoryId { get; set; }
    public FoodCategory FoodCategory { get; set; } = null!;

    public ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();
}
