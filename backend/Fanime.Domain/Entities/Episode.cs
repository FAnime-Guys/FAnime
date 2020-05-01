using System;

namespace Fanime.Domain.Entities
{
    public class Episode
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }

        public DateTime AirDate { get; set; }
    }
}
