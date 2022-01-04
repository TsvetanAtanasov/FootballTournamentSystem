namespace Core.Infrastructure.Persistence
{
    using Core.Domain;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;

    public class FootballTournamentDataRepository<TEntity> : DataRepository<TournamentDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(TournamentDbContext db) : base(db) { }
    }
}
