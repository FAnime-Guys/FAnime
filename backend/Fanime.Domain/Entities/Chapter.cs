namespace Fanime.Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }

        public int MangaId { get; set; }
        public Manga Manga { get; set; }

        public string Description { get; set; }
    }
}
