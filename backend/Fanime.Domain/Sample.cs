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

            Donovan.Friends = new[]
            {
                new Friends { UserId = 1, FriendId = 2, Friend = Louis, Status = FriendStatus.Accepted  },
                new Friends { UserId = 1, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new Friends { UserId = 1, FriendId = 4, Friend = James, Status = FriendStatus.Pending }, // will not have invited date, only accepted date if ever accepted
            };

            Louis.Friends = new[]
            {
                new Friends { UserId = 2, FriendId = 1, Friend = Donovan, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 3, Friend = Jason, Status = FriendStatus.Accepted  },
                new Friends { UserId = 2, FriendId = 5, Friend = Paul, Status = FriendStatus.Accepted  },
            };

            James.Friends = new[]
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

        public void TestAnimeMangaCharacterLists()
        {
            var Donovan = new User { Id = 1, DisplayName = "Donovan" };

            var character = new Character { Id = 1, Firstname = "Yumeko", Lastname = "Jabami" };

            var anime = new Anime { Id = 1, Title = "Kakegurui", Type = AnimeType.TV, Characters = new[] { character } };
            var manga = new Manga { Id = 1, Title = "Kakegurui Joker", Characters = new[] { character } };

            var characterCI = new CollectionItem { Id = 1, UserId = 1, User = Donovan, EntityId = 1, Entity = character };
            var animeCI = new CollectionItem { Id = 2, UserId = 1, User = Donovan, EntityId = 1, Entity = anime, Status = CollectionStatus.Completed };
            var mangaCI = new CollectionItem { Id = 3, UserId = 1, User = Donovan, EntityId = 1, Entity = manga, Status = CollectionStatus.PlanToRead };

            Donovan.Collections = new[] { characterCI, animeCI, mangaCI };

            var animeCount = Donovan.Collections.Count(c => c.Entity.GetType() == typeof(Anime));
            var mangaCount = Donovan.Collections.Count(c => c.Entity.GetType() == typeof(Manga));
            var characterCount = Donovan.Collections.Count(c => c.Entity.GetType() == typeof(Character));
        }
    }
}
