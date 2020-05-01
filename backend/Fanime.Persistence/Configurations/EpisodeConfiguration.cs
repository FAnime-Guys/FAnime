using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.ToTable("episodes");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.AnimeId).HasColumnName("anime_id");
            builder.Property(e => e.Title).HasMaxLength(150).HasColumnName("title");
            builder.Property(e => e.Summary).HasColumnName("summary");
            builder.Property(e => e.AirDate).HasColumnName("air_date");

            builder.HasOne(e => e.Anime)
                .WithMany(a => a.Episodes)
                .HasForeignKey(e => e.AnimeId);
        }

    }
}
