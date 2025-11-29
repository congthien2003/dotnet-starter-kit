using Domain.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public enum RideStatus
    {
        Requested,
        Accepted,
        InProgress,
        Completed,
        Cancelled
    }

    public class Ride : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid? DriverId { get; private set; }
        public Location Pickup { get; private set; }
        public Location Destination { get; private set; }
        public decimal? Fare { get; private set; }
        public RideStatus Status { get; private set; }

        public Ride(Guid id, Guid userId, Location pickup, Location destination)
        {
            Id = id;
            UserId = userId;
            Pickup = pickup;
            Destination = destination;
            Status = RideStatus.Requested;
        }

        public void AssignDriver(Guid driverId)
        {
            if (Status != RideStatus.Requested)
                throw new InvalidOperationException("Driver can only be assigned while Requested.");

            DriverId = driverId;
            Status = RideStatus.Accepted;
        }

        public void StartRide()
        {
            if (Status != RideStatus.Accepted)
                throw new InvalidOperationException("Ride can only start if Accepted.");
            Status = RideStatus.InProgress;
        }

        public void CompleteRide(decimal fare)
        {
            if (Status != RideStatus.InProgress)
                throw new InvalidOperationException("Ride can only be completed if InProgress.");
            Fare = fare;
            Status = RideStatus.Completed;
        }
    }
}
