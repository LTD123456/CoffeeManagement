using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class FoodCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Food> Foods { get; } = new List<Food>();
}
