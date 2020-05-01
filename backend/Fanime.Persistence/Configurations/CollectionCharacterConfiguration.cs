using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class CollectionCharacterConfiguration : IEntityTypeConfiguration<CollectionCharacter>
    {
        public void Configure(EntityTypeBuilder<CollectionCharacter> builder)
        {
            builder.ToTable("collection_characters");

            builder.HasKey(cc => new { cc.CharacterId, cc.CollectionId });

            builder.Property(cc => cc.CharacterId).HasColumnName("character_id");
            builder.Property(cc => cc.CollectionId).HasColumnName("collection_id");
        }
    }
}
