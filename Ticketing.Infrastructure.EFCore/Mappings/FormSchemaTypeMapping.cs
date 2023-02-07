using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Domain.FormTypeAgg;

namespace Ticketing.Infrastructure.EFCore.Mappings;

public class FormSchemaTypeMapping : IEntityTypeConfiguration<FormSchemaType>
{
    public void Configure(EntityTypeBuilder<FormSchemaType> builder)
    {
        builder.ToTable("FormSchemaTypes");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
        builder.Property(x => x.IsActive).IsRequired();
        builder.Property(x => x.CreationDate).IsRequired();
    }
}