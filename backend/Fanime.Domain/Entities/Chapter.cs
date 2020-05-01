namespace Fanime.Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public int MangaId { get; set; }
        public Manga Manga { get; set; }
    }
}
