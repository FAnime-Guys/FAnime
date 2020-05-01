using System.Linq;
using Fanime.Domain.Entities;

namespace Fanime.Domain
{
    

    class Sample
    {
        public void TestFriends()
        {
            var Donovan = new User { Id = 1, DisplayName = "Donovan" };
            var Louis = new User { Id = 2, DisplayName = "Louis" };
            var Jason = new User { Id = 3, DisplayName = "Jason" };
            var James = new User { Id = 4, DisplayName = "James" };
            var Paul = new User { Id = 5, DisplayName = "Paul" };

            Donovan.Friends = new[]
            {
                new UserFriend { UserId = 1, FriendId = 2, Friend = Louis, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 1, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 1, FriendId = 4, Friend = James, Status = FriendStatus.Pending }, // will not have invited date, only accepted date if ever accepted
            };

            Louis.Friends = new[]
            {
                new UserFriend { UserId = 2, FriendId = 1, Friend = Donovan, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 2, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 2, FriendId = 5, Friend = Paul, Status = FriendStatus.Accepted  },
            };

            James.Friends = new[]
            {
                new UserFriend { UserId = 2, FriendId = 1, Friend = Donovan, Status = FriendStatus.Invited  }, // has invited date
                new UserFriend { UserId = 2, FriendId = 1, Friend = Louis, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 2, FriendId = 1, Friend = Jason, Status = FriendStatus.Accepted  },
                new UserFriend { UserId = 2, FriendId = 1, Friend = Paul, Status = FriendStatus.Accepted  },
            };


            int friends = Donovan.Friends.Where(f => f.Status == FriendStatus.Accepted).Count();
            // to list pending invites or pending invitations awaiting acception
            int pending = Donovan.Friends.Where(f => f.Status == FriendStatus.Invited || f.Status == FriendStatus.Pending).Count();
        }

        public void TestAnimeMangaCharacterLists()
        {
            var Donovan = new User { Id = 1, DisplayName = "Donovan" };

            var anime = new Anime { Id = 1, Title = "Kakegurui", Type = AnimeType.TV };
            var manga = new Manga { Id = 1, Title = "Kakegurui Joker" };

            var animeCI = new CollectionItem { Id = 2, UserId = 1, User = Donovan, CollectionId = 1, Collection = anime, Status = CollectionStatus.Completed };
            var mangaCI = new CollectionItem { Id = 3, UserId = 1, User = Donovan, CollectionId = 1, Collection = manga, Status = CollectionStatus.PlanToRead };

            Donovan.Collections = new[] { animeCI, mangaCI };

            // Instead have separate favourite lists for these
            // Donovan.Characters
            // Donovan.Authors
            // Donovan.Studios (Maybe this can be shared with producers)
            // Donovan.Producers

            var animeCount = Donovan.Collections.Count(c => c.Collection.GetType() == typeof(Anime));
            var mangaCount = Donovan.Collections.Count(c => c.Collection.GetType() == typeof(Manga));
        }
    }
}
