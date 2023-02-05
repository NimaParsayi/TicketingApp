using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Infrastructure.EFCore.Mappings;

public class FormSchemaMapping : IEntityTypeConfiguration<FormSchema>
{
    public void Configure(EntityTypeBuilder<FormSchema> builder)
    {
        builder.ToTable("FormSchemas");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(300);
        builder.Property(x => x.IsActive).IsRequired();

        builder.HasMany(x => x.Fields).WithOne(x => x.FormSchema).HasForeignKey(x => x.FormSchemaId);
    }
}