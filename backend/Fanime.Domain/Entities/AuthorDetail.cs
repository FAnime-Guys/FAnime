using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class AuthorDetail
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int MangaId { get; set; }
        public Manga Manga { get; set; }
    }
}
