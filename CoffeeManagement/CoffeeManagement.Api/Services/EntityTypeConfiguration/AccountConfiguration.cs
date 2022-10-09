using CoffeeManagement.Api.Commons.DataModel;
using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeManagement.Api.Services.EntityTypeConfiguration;

public sealed class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1001, 1);

        builder.Property(x => x.UserName).HasMaxLength(FieldLengths.Account.UserName).IsRequired(true);
        builder.Property(x => x.Password).HasMaxLength(FieldLengths.Account.PassWord).IsRequired(true);
        builder.Property(x => x.DisplayName).HasMaxLength(FieldLengths.Account.DisplayName).IsRequired(true);
    }
}
