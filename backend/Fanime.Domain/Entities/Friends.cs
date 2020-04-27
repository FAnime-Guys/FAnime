﻿using System;

namespace Fanime.Domain.Entities
{
    public class Friends
    {
        public FriendStatus Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int FriendId { get; set; }
        public User Friend { get; set; }

        public DateTime? Invited { get; set; }
        public DateTime? Accepted { get; set; }
        public DateTime? Blocked { get; set; }
    }

    public enum FriendStatus
    {
        Invited = 0,
        Pending = 1,
        Accepted = 2,
    }
}