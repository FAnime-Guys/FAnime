using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class VoiceActor
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string LastName { get; set; }

        public IEnumerable<VoiceActorDetail> VoiceActorDetails { get; set; }
    }
}
