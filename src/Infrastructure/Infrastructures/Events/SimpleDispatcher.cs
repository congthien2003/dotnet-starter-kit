using Domain.Events;
namespace Infrastructures.Events
{
    public class SimpleDispatcher : IDomainEventDispatcher
    {
        public Task PublishAsync(object @event)
        {
            // For sample, just write to console (in real app use message bus)
            Console.WriteLine($"[DomainEvent] {@event.GetType().Name} - {@event}");
            return Task.CompletedTask;
        }
    }
}
