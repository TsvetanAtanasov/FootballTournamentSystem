namespace Common.Infrastructure.Events
{
    using System.Threading.Tasks;
    using Domain;

    public interface IEventDispatcher
    {
        Task Dispatch(IDomainEvent domainEvent);
    }
}
