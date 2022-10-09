using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeManagement.Api.Services.EntityTypeConfiguration;

public sealed class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1001, 1);

        builder.Property(x => x.CheckIn).IsRequired(true);
        builder.Property(x => x.Status).IsRequired(true);

        builder.HasOne(x => x.TableFood).WithMany(x => x.Bills).HasForeignKey(x => x.TableFoodId);
        builder.HasOne(x => x.Account).WithMany(x => x.Bills).HasForeignKey(x => x.AccountId);
    }
}
