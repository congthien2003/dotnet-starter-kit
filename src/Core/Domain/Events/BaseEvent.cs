namespace Domain.Events
{
    public abstract class BaseEvent
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
