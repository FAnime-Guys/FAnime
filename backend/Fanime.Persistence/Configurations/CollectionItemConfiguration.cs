using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class CollectionItemConfiguration : IEntityTypeConfiguration<CollectionItem>
    {
        public void Configure(EntityTypeBuilder<CollectionItem> builder)
        {
            builder.ToTable("collection_items");

            builder.HasKey(ci => new { ci.Id, ci.CollectionId, ci.UserId });

            builder.Property(ci => ci.Id).HasColumnName("id");
            builder.Property(ci => ci.CollectionId).HasColumnName("collection_id");
            builder.Property(ci => ci.UserId).HasColumnName("user_id");
            builder.Property(ci => ci.Status).HasColumnType("varchar(20)").HasColumnName("status");

            builder.HasOne(ci => ci.Collection)
                .WithMany(cb => cb.Collections)
                .HasForeignKey(ci => ci.CollectionId);

            builder.HasOne(ci => ci.User)
                .WithMany(u => u.Collections)
                .HasForeignKey(ci => ci.UserId);
        }
    }
}
