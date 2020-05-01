using System;
using System.Collections.Generic;
using System.Text;

namespace Fanime.Domain.Entities
{
    public class Producer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<ProducerStudioDetail> ProducerStudioDetails { get; set; }
    }
}
