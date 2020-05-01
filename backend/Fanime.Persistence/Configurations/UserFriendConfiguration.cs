using Fanime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fanime.Persistence.Configurations
{
    public class UserFriendConfiguration : IEntityTypeConfiguration<UserFriend>
    {
        public void Configure(EntityTypeBuilder<UserFriend> builder)
        {
            builder.ToTable("user_friends");

            builder.HasKey(uf => new { uf.UserId, uf.FriendId, uf.Status });

            builder.Property(uf => uf.UserId).HasColumnName("user_id");
            builder.Property(uf => uf.FriendId).HasColumnName("friend_id");
            builder.Property(uf => uf.Status).IsRequired().HasColumnType("varchar(20)").HasColumnName("status");
            builder.Property(uf => uf.Invited).HasColumnName("invited");
            builder.Property(uf => uf.Accepted).HasColumnName("accepted");
            builder.Property(uf => uf.Blocked).HasColumnName("blocked");

            builder.HasOne(uf => uf.User)
                .WithMany()
                .HasForeignKey(uf => uf.UserId);

            builder.HasOne(uf => uf.Friend)
                .WithMany()
                .HasForeignKey(uf => uf.FriendId);
        }
    }
}
