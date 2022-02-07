namespace FootballTournamentSystem.Person.Infrastructure.Repositories
{
    using Core.Domain;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;

    public class FootballTournamentDataRepository<TEntity> : DataRepository<PersonDbContext, TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected FootballTournamentDataRepository(PersonDbContext db) : base(db) { }
    }
}
