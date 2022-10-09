using System.Diagnostics.CodeAnalysis;

namespace CoffeeManagement.Api.DataModel;

[ExcludeFromCodeCoverage]
public sealed class Account
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? DisplayName { get; set; }
    public string? Password { get; set; }
    public AccountType Type { get; set; }

    public ICollection<Bill> Bills { get; } = new List<Bill>();
}