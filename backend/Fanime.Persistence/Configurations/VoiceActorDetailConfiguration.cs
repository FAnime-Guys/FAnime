using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class VoiceActorDetailConfiguration : IEntityTypeConfiguration<VoiceActorDetail>
    {
        public void Configure(EntityTypeBuilder<VoiceActorDetail> builder)
        {
            builder.ToTable("voice_actor_details");

            builder.HasKey(vad => new { vad.VoiceActorId, vad.CharacterId });

            builder.Property(vad => vad.VoiceActorId).HasColumnName("voice_actor_id");
            builder.Property(vad => vad.CharacterId).HasColumnName("character_id");

            builder.HasOne(vad => vad.VoiceActor)
                .WithMany(va => va.VoiceActorDetails)
                .HasForeignKey(vad => vad.VoiceActorId);

            builder.HasOne(vad => vad.Character)
                .WithMany(c => c.VoiceActorDetails)
                .HasForeignKey(vad => vad.CharacterId);
        }

    }
}
