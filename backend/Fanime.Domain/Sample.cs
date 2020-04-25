using System.Collections.Generic;
using System.Linq;

namespace Fanime.Domain
{
    using Entities;

    class Sample
    {
        public void TestFriends()
        {
            var Donovan = new User { Id = 1, DisplayName = "Donovan" };
            var Louis = new User { Id = 2, DisplayName = "Louis" };
            var Jason = new User { Id = 3, DisplayName = "Jason" };
            var James = new User { Id = 4, DisplayName = "James" };
            var Paul = new User { Id = 5, DisplayName = "Paul" };

            Donovan.Friends = new List<Friends>
            {
                new Friends { UserId = 1, FriendId = 2, Friend = Louis, Status = FriendStatus.Accepted  },
                new Friends { UserId = 1, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new Friends { UserId = 1, FriendId = 4, Friend = James, Status = FriendStatus.Pending }, // will not have invited date, only accepted date if ever accepted
            };

            Louis.Friends = new List<Friends>
            {
                new Friends { UserId = 2, FriendId = 1, Friend = Donovan, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 5, Friend = Paul, Status = FriendStatus.Accepted  },
            };

            James.Friends = new List<Friends>
            {
                new Friends { UserId = 2, FriendId = 1, Friend = Donovan, Status = FriendStatus.Invited  }, // has invited date
                new Friends { UserId = 2, FriendId = 1, Friend = Louis, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 1, Friend = Jason, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 1, Friend = Paul, Status = FriendStatus.Accepted  },
            };


            int friends = Donovan.Friends.Where(f => f.Status == FriendStatus.Accepted).Count();
            // to list pending invites or pending invitations awaiting acception
            int pending = Donovan.Friends.Where(f => f.Status == FriendStatus.Invited || f.Status == FriendStatus.Pending).Count();
        }
    }
}
