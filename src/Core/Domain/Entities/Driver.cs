using Domain.Abstractions;

namespace Domain.Entities
{
    public class Driver : BaseEntity
    {
        public string Name { get; private set; }
        public string VehicleInfo { get; private set; }
        public bool IsAvailable { get; private set; }

        public Driver(Guid id, string name, string vehicleInfo, bool isAvailable = true)
        {
            Id = id;
            Name = name;
            VehicleInfo = vehicleInfo;
            IsAvailable = isAvailable;
        }

        public void SetAvailability(bool available) => IsAvailable = available;
    }
}
