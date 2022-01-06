namespace FootballTournamentSystem.Person.Infrastructure.Repositories.Referee
{
    using FootballTournamentSystem.Person.Domain.Models.Referee;
    using FootballTournamentSystem.Person.Application.Features.President;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;

    internal class RefereeRepository : FootballTournamentDataRepository<Referee>, IRefereeRepository
    {
        public RefereeRepository(PersonDbContext db)
            : base(db)
        {

        }
    }
}
