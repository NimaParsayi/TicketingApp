using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Domain.FormReplyAgg;

namespace Ticketing.Infrastructure.EFCore.Mappings;

public class FormReplyMapping : IEntityTypeConfiguration<FormReply>
{
    public void Configure(EntityTypeBuilder<FormReply> builder)
    {
        builder.ToTable("FormsReplies");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Mobile).HasMaxLength(12).IsRequired();
        builder.Property(x => x.CreationDate).IsRequired();
        builder.Property(x => x.Message).IsRequired();
        builder.Property(x => x.FormId).IsRequired();
        builder.Property(x => x.ReplyToMessageId);

        builder.HasOne(x => x.Form).WithMany(x => x.Replies).HasForeignKey(x => x.FormId);
        builder.HasOne(x => x.ReplyToMessage).WithOne(x => x.ReplyToMessage);
    }
}
