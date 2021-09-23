namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Coach
{
    using Domain.Models.Person.Coach;
    using FootballTournamentSystem.Application.Features.Person.Coach;
    using FootballTournamentSystem.Infrastructure.Persistence.Repositories;

    internal class CoachRepository : FootballTournamentDataRepository<Coach>, ICoachRepository
    {
        public CoachRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
