using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual IEnumerable<CollectionCharacter> CollectionCharacters { get; set; }    // Manga or Anime
        public virtual IEnumerable<VoiceActorDetail> VoiceActorDetails { get; set; }
    }
}
