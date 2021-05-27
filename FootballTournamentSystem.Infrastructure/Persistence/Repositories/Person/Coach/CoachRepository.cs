namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.Coach
{
    using Domain.Models.PersonContext.Coach;
    using FootballTournamentSystem.Application.Features.PersonContext.Coach;

    internal class CoachRepository : DataRepository<Coach>, ICoachRepository
    {
        public CoachRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
