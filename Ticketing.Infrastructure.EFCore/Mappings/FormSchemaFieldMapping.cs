using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Domain.FormSchemaFieldAgg;

namespace Ticketing.Infrastructure.EFCore.Mappings;

public class FormSchemaFieldMapping : IEntityTypeConfiguration<FormSchemaField>
{
    public void Configure(EntityTypeBuilder<FormSchemaField> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasMaxLength(300);
        builder.Property(x => x.IsActive).IsRequired();
        builder.Property(x => x.FormSchemaId).IsRequired();

        builder.HasOne(x => x.FormSchema).WithMany(x => x.Fields).HasForeignKey(x => x.FormSchemaId);
    }
}