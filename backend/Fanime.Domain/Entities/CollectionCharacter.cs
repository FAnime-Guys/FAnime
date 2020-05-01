using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class CollectionCharacter
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int CollectionId { get; set; }
        public CollectionBase Collection { get; set; }
    }
}
