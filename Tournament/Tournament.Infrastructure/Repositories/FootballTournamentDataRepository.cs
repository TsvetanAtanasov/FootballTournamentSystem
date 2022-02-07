namespace FootballTournamentSystem.Tournament.Infrastructure.Repositories
{
    using Core.Domain;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;

    public class FootballTournamentDataRepository<TEntity> : DataRepository<TournamentDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(TournamentDbContext db) : base(db) { }
    }
}
