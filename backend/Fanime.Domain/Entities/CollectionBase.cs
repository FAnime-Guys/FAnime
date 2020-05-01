using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public abstract class CollectionBase
    {
        public int Id { get; set; }

        public virtual IEnumerable<CollectionCharacter> CollectionCharacters { get; set; }
        public virtual IEnumerable<Review> Reviews { get; set; }
        public virtual IEnumerable<CollectionItem> Collections { get; set; }
    }
}
