using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class BillInfo
{
    public int Id { get; set; }
    public int Count { get; set; } = 0;

    public int BillId { get; set; }
    public Bill? Bill { get; set; }

    public int FoodId { get; set; }
    public Food? Food { get; set; }
}
