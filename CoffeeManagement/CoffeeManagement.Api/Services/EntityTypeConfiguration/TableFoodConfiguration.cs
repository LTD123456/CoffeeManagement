using CoffeeManagement.Api.Commons.DataModel;
using CoffeeManagement.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeManagement.Api.Services.EntityTypeConfiguration;

public sealed class TableFoodConfiguration : IEntityTypeConfiguration<TableFood>
{
    public void Configure(EntityTypeBuilder<TableFood> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn(1001, 1);

        builder.Property(x => x.Name).HasMaxLength(FieldLengths.Common.Name).IsRequired(true);
    }
}
