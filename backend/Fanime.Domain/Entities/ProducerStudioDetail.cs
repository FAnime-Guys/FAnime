namespace Fanime.Domain.Entities
{
    public class ProducerStudioDetail
    {
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
