using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Domain.FormAgg;

namespace Ticketing.Infrastructure.EFCore.Mappings;

public class FormMapping : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.ToTable("Forms");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Mobile).HasMaxLength(12).IsRequired();
        builder.Property(x => x.Data).HasConversion<string>(x=>x.ToString()).IsRequired();
        builder.Property(x => x.CreationDate).IsRequired();
    }
}
