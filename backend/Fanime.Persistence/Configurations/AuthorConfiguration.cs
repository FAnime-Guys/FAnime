using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("authors");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Firstname).HasMaxLength(150).IsRequired().HasColumnName("firstname");
            builder.Property(a => a.Lastname).HasMaxLength(150).IsRequired().HasColumnName("lastname");
        }

    }
}
