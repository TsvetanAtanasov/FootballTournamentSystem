namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.Coach
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.PersonContext.Coach;
    using FootballTournamentSystem.Application.Features.PersonContext.Coach;

    internal class CoachRepository : DataRepository<FootballTournamentDbContext, Coach>, ICoachRepository
    {
        public CoachRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
