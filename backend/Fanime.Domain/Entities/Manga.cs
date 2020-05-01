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

        // Not sure if the below is required, I feel like it may be since some Manga
        //public DateTime? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }

        // How do volumes fit into this picture?
        public virtual IEnumerable<Chapter> Chapters { get; set; }
        public virtual IEnumerable<AuthorDetail> AuthorDetails { get; set; }
    }
}
