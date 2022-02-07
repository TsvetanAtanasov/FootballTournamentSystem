namespace FootballTournamentSystem.Person.Infrastructure.Repositories.Coach
{
    using FootballTournamentSystem.Person.Domain.Models.Coach;
    using FootballTournamentSystem.Person.Application.Features.Coach;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;

    internal class CoachRepository : FootballTournamentDataRepository<Coach>, ICoachRepository
    {
        public CoachRepository(PersonDbContext db)
            : base(db)
        {

        }
    }
}
