namespace Core.Application.Contracts
{
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Domain;
    using Core.Domain.Models;

    public interface IRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task MarkMessageAsPublished(int id);

        Task Save(TEntity entity, CancellationToken cancellationToken = default, params Message[] messages);
    }
}
