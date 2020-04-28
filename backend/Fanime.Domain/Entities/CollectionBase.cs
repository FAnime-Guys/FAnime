using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public abstract class CollectionBase
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<CollectionItem> Collections { get; set; }
    }
}
