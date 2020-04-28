namespace Fanime.Domain.Entities
{
    public class CollectionItem
    {
        public int Id { get; set; }
        
        public int EntityId { get; set; }
        public CollectionBase Entity { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public CollectionStatus? Status { get; set; }
    }

    public enum CollectionStatus
    {
        Watching = 1,
        Reading = 2,
        Completed = 3,
        OnHold = 4,
        Dropped = 5,
        PlanToWatch = 6,
        PlanToRead = 7
    }
}
