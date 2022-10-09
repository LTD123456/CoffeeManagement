using CoffeeManagement.Api.Commons.DataModel;
using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeManagement.Api.Services.EntityTypeConfiguration;


public sealed class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1001, 1);

        builder.Property(x => x.Name).HasMaxLength(FieldLengths.Common.Name).IsRequired(true);
        builder.Property(x => x.Price).IsRequired(true);

        builder.HasOne(x => x.FoodCategory).WithMany(x => x.Foods).HasForeignKey(x => x.FoodCategoryId);
    }
}
