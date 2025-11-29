namespace Domain.Events
{
    public interface IDomainEventDispatcher
    {
        Task PublishAsync(object @event);
    }
}
