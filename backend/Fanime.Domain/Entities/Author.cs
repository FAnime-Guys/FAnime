using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual IEnumerable<AuthorDetail> AuthorDetails { get; set; }
    }
}
