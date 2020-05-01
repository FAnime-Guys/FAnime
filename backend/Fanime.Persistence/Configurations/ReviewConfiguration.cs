using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("reviews");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id).HasColumnName("id");
            builder.Property(r => r.UserId).HasColumnName("user_id");
            builder.Property(r => r.Description).IsRequired().HasColumnName("description");
            builder.Property(r => r.EntityId).HasColumnName("collection_id");

            builder.HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            builder.HasOne(r => r.Entity)
                .WithMany(cb => cb.Reviews)
                .HasForeignKey(r => r.EntityId);
        }

    }
}
