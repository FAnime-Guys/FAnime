using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class CollectionBaseConfiguration : IEntityTypeConfiguration<CollectionBase>
    {
        public void Configure(EntityTypeBuilder<CollectionBase> builder)
        {
            builder.ToTable("collections");

            builder.HasKey(cb => cb.Id);

            builder.HasDiscriminator<string>("collection_type")
                .HasValue<Anime>("anime")
                .HasValue<Manga>("manga");

            builder.Property(cb => cb.Id).HasColumnName("id");
        }
    }
}
