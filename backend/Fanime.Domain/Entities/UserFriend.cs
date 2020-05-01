using System;

namespace Fanime.Domain.Entities
{
    public class UserFriend
    {
        public int UserId { get; set; }
        public User User { get; set; } // Current Person

        public int FriendId { get; set; }
        public User Friend { get; set; } // Current Person's friend

        public FriendStatus Status { get; set; }

        public DateTime? Invited { get; set; }
        public DateTime? Accepted { get; set; }
        public DateTime? Blocked { get; set; }
    }

    public enum FriendStatus
    {
        Invited = 0,
        Pending = 1,
        Accepted = 2,
        Blocked = 3
    }
}
