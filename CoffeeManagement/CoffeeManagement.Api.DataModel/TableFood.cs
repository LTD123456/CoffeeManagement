using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class TableFood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public TableFoodStatus Status { get; set; } = TableFoodStatus.Orther;

    public ICollection<Bill> Bills { get; } = new List<Bill>();
}