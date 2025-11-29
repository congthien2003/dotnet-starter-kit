namespace Domain.Events
{
    public class RideRequestedEvent
    {
        public Guid RideId { get; }
        public Guid UserId { get; }

        public RideRequestedEvent(Guid rideId, Guid userId)
        {
            RideId = rideId;
            UserId = userId;
        }
    }
}
