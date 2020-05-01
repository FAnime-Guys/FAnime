using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class MangaConfiguration : IEntityTypeConfiguration<Manga>
    {
        public void Configure(EntityTypeBuilder<Manga> builder)
        {
            builder.HasBaseType(typeof(CollectionBase));

            builder.Property(m => m.Title).HasMaxLength(250).IsRequired().HasColumnName("title");
            builder.Property(m => m.Kanji).HasMaxLength(250).IsRequired().HasColumnName("kanji");
            builder.Property(m => m.Romanji).HasMaxLength(250).IsRequired().HasColumnName("romanji");
            builder.Property(m => m.Synonyms).HasColumnName("synonyms");

        }

    }
}
