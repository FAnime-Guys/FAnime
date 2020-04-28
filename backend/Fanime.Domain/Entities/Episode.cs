namespace Fanime.Domain.Entities
{
    public class Episode
    {
        public int Id { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }

        public string Description { get; set; }
    }
}
