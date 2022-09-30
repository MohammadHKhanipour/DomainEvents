namespace DomainEvents
{
    public interface IDomainEntity
    {
        void RaiseEvent(IEvent @event);
        IEnumerable<IEvent> GetEvents();
        void ClearEvents();
    }

    public abstract class DomainEntity : IDomainEntity
    {
        private readonly List<IEvent> _events = new();

        public void RaiseEvent(IEvent @event) => _events.Add(@event);

        public IEnumerable<IEvent> GetEvents() => _events;

        public void ClearEvents() => throw new NotImplementedException();
    }
}
