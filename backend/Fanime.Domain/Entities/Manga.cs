using System;
using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class Manga : CollectionBase
    {
        public string Title { get; set; } // English / Common Name?
        public string Kanji { get; set; } // Japanese Kanji
        public string Romanji { get; set; } // Japanese Romanji

        public string Synonyms { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<Chapter> Chapters { get; set; }
        public IEnumerable<Character> Characters { get; set; }
        public IEnumerable<AuthorDetail> AuthorDetails { get; set; }
    }
}
