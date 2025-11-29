namespace Domain.Events
{
    public class RideAcceptedEvent
    {
        public Guid RideId { get; }
        public Guid DriverId { get; }

        public RideAcceptedEvent(Guid rideId, Guid driverId)
        {
            RideId = rideId;
            DriverId = driverId;
        }
    }
}
