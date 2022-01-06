namespace FootballTournamentSystem.Person.Infrastructure.Repositories.President
{
    using FootballTournamentSystem.Person.Domain.Models.President;
    using FootballTournamentSystem.Person.Application.Features.President;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;

    internal class PresidentRepository : FootballTournamentDataRepository<President>, IPresidentRepository
    {
        public PresidentRepository(PersonDbContext db)
            : base(db)
        {

        }
    }
}
