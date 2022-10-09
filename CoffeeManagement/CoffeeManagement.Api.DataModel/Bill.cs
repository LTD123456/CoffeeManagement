using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class Bill
{
    public int Id { get; set; }
    public DateTime? CheckIn { get; set; } = DateTime.Now;
    public DateTime? CheckOut { get; set; } = null!;
    public BillStatus Status { get; set; } = BillStatus.Unpaid;

    public int TableFoodId { get; set; }
    public TableFood? TableFood { get; set; }

    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public ICollection<BillInfo> BillInfos { get;} = new List<BillInfo>();
}
