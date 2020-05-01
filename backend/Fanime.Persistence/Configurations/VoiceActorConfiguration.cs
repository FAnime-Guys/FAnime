using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class VoiceActorConfiguration : IEntityTypeConfiguration<VoiceActor>
    {
        public void Configure(EntityTypeBuilder<VoiceActor> builder)
        {
            builder.ToTable("voice_actors");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Firstname).HasMaxLength(150).IsRequired().HasColumnName("firstname");
            builder.Property(e => e.Lastname).HasMaxLength(150).IsRequired().HasColumnName("lastname");
        }

    }
}
