using System;
using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class User
    {
        public User()
        {
            Friends = new HashSet<Friends>();
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }

        public string Image { get; set; } // Profile Picture

        public string Email { get; set; }
        
        public string DisplayName { get; set; }

        public string Gender { get; set; }

        public string Location { get; set; }

        public string Biography { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? EmailConfirmed { get; set; } // Use as a boolean flag to determine when the email address was confirmed

        public DateTime Created { get; set; } // Use to determine when the account was created, this date can be different to email confirmation

        public DateTime? Deactivated { get; set; } // Use as a boolean flag to determine if they are active or not


        // Collections

        public IEnumerable<Friends> Friends { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<CollectionItem> Collections { get; set; }
    }

    
}
