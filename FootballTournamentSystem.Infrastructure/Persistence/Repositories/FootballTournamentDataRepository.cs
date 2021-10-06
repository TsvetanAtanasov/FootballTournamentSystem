namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories
{
    using Core.Domain;
    using Core.Infrastructure.Persistence;

    // Use interfaces in the first generic parameter
    public class FootballTournamentDataRepository<TEntity> : DataRepository<FootballTournamentDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(FootballTournamentDbContext db) : base(db) { }
    }
}
