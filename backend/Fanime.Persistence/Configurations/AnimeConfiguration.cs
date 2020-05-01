using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.HasBaseType(typeof(CollectionBase));

            builder.Property(a => a.Title).HasMaxLength(250).IsRequired().HasColumnName("title");
            builder.Property(a => a.Kanji).HasMaxLength(250).IsRequired().HasColumnName("kanji");
            builder.Property(a => a.Romanji).HasMaxLength(250).IsRequired().HasColumnName("romanji");

            builder.Property(a => a.Synonyms).HasColumnName("synonyms");
            builder.Property(a => a.Summary).HasColumnName("summary");

            builder.Property(a => a.StartDate).HasColumnName("start_date");
            builder.Property(a => a.EndDate).HasColumnName("end_date");

            builder.Property(a => a.Type).HasColumnType("varchar(10)").IsRequired().HasColumnName("anime_type");
        }

    }
}
