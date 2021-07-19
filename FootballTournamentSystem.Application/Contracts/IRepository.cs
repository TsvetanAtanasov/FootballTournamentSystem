namespace FootballTournamentSystem.Application.Contracts
{
    using System.Threading;
    using System.Threading.Tasks;
    using global::Common.Domain;

    public interface IRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task Save(TEntity entity, CancellationToken cancellationToken = default);
    }
}
