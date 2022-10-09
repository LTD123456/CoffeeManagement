using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeManagement.Api.Services.EntityTypeConfiguration;

public class BillInfoConfiguration : IEntityTypeConfiguration<BillInfo>
{
    public void Configure(EntityTypeBuilder<BillInfo> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1001, 1);

        builder.Property(x => x.Count).IsRequired(true);

        builder.HasOne(x => x.Food).WithMany(x => x.BillInfos).HasForeignKey(x => x.FoodId);
        builder.HasOne(x => x.Bill).WithMany(x => x.BillInfos).HasForeignKey(x => x.BillId);
    }
}
