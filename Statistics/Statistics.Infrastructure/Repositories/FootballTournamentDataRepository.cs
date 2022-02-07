namespace FootballTournamentSystem.Statistics.Infrastructure.Repositories
{
    using Core.Domain;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;

    public class FootballTournamentDataRepository<TEntity> : DataRepository<StatisticsDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(StatisticsDbContext db) : base(db) { }
    }
}
