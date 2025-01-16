using CMSPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSPlus.Domain.Configurations;

public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
{

    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.HasOne(c => c.Topic)
            .WithMany(t => t.Comments)
            .HasForeignKey(c => c.TopicId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Comments");
        builder.Property(x => x.TopicId).IsRequired();
        builder.Property(x => x.Author).IsRequired();
        builder.Property(x => x.Body).IsRequired();
    }
}
