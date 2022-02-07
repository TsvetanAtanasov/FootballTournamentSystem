namespace Core.Application
{
    using System.Threading.Tasks;
    using Core.Domain;

    public interface IEventHandler<in TEvent>
        where TEvent : IDomainEvent
    {
        Task Handle(TEvent domainEvent);
    }
}
