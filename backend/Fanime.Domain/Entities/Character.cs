using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class Character : CollectionBase
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int EntityId { get; set; } // Manga or Anime
        public CollectionBase Entity { get; set; }

        public IEnumerable<VoiceActor> VoiceActors { get; set; }
    }
}
