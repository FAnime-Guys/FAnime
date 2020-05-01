using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class ProducerStudioDetailConfiguration : IEntityTypeConfiguration<ProducerStudioDetail>
    {
        public void Configure(EntityTypeBuilder<ProducerStudioDetail> builder)
        {
            builder.ToTable("producer_studio_details");

            builder.HasKey(psd => new { psd.AnimeId, psd.ProducerId, psd.StudioId });

            builder.Property(psd => psd.AnimeId).HasColumnName("anime_id");
            builder.Property(psd => psd.ProducerId).HasColumnName("producer_id");
            builder.Property(psd => psd.StudioId).HasColumnName("studio_id");

            builder.HasOne(psd => psd.Anime)
                .WithMany(a => a.ProducerStudioDetails)
                .HasForeignKey(psd => psd.AnimeId);

            builder.HasOne(psd => psd.Producer)
                .WithMany(p => p.ProducerStudioDetails)
                .HasForeignKey(psd => psd.ProducerId);

            builder.HasOne(psd => psd.Studio)
                .WithMany(s => s.ProducerStudioDetails)
                .HasForeignKey(psd => psd.StudioId);
        }

    }
}
