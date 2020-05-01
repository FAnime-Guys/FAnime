using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        
        public int EntityId { get; set; } // Anime or Manga
        public CollectionBase Entity { get; set; }
    }
}
