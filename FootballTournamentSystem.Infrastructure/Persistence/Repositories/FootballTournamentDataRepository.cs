namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories
{
    using Common.Domain;
    using Common.Infrastructure.Persistence;

    // Use interfaces in the first generic parameter
    public class FootballTournamentDataRepository<TEntity> : DataRepository<FootballTournamentDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(FootballTournamentDbContext db) : base(db) { }
    }
}
