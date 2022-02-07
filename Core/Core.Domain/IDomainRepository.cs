namespace Core.Domain
{
    using Core.Domain.Models;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDomainRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task MarkMessageAsPublished(int id);

        Task Save(TEntity entity, CancellationToken cancellationToken = default, params Message[] messages);
    }
}
