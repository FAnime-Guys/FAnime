using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class VoiceActorDetail
    {
        public int VoiceActorId { get; set; }
        public VoiceActor VoiceActor { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
