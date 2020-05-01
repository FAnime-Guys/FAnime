using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class VoiceActor
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual IEnumerable<VoiceActorDetail> VoiceActorDetails { get; set; }
    }
}
