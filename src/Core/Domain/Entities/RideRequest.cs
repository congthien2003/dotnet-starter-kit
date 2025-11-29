using Domain.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class RideRequest : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Location Pickup { get; private set; }
        public Location Destination { get; private set; }
        public DateTime RequestedAt { get; private set; }

        public RideRequest(Guid id, Guid userId, Location pickup, Location destination)
        {
            Id = id;
            UserId = userId;
            Pickup = pickup;
            Destination = destination;
            RequestedAt = DateTime.UtcNow;
        }
    }
}
