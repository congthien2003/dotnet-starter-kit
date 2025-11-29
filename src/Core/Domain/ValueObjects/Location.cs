namespace Domain.ValueObjects
{
    public record Location(double Latitude, double Longitude)
    {
        public override string ToString() => $"({Latitude}, {Longitude})";
    }
}
