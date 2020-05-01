using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class AuthorDetailConfiguration : IEntityTypeConfiguration<AuthorDetail>
    {
        public void Configure(EntityTypeBuilder<AuthorDetail> builder)
        {
            builder.ToTable("author_details");

            builder.HasKey(ad => new { ad.AuthorId, ad.MangaId });

            builder.Property(ad => ad.AuthorId).HasColumnName("author_id");
            builder.Property(ad => ad.MangaId).HasColumnName("manga_id"); // We can call this collection_id

            builder.HasOne(ad => ad.Author)
                .WithMany(a => a.AuthorDetails)
                .HasForeignKey(ad => ad.AuthorId);

            builder.HasOne(ad => ad.Manga)
                .WithMany(m => m.AuthorDetails)
                .HasForeignKey(ad => ad.MangaId);
        }

    }
}
