using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("id");
            builder.Property(u => u.Image).HasColumnName("image");
            builder.Property(u => u.Email).IsRequired().HasColumnName("email");
            builder.Property(u => u.DisplayName).HasMaxLength(150).IsRequired().HasColumnName("display_name");
            builder.Property(u => u.Gender).HasColumnName("gender");
            builder.Property(u => u.Location).HasColumnName("location");
            builder.Property(u => u.Biography).HasColumnName("biography");
            builder.Property(u => u.DateOfBirth).HasColumnName("date_of_birth");
            builder.Property(u => u.EmailConfirmed).HasColumnName("email_confirmed");
            builder.Property(u => u.Created).HasColumnName("created");
            builder.Property(u => u.Deactivated).HasColumnName("deactivated");
        }

    }
}
