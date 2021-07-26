namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.Referee
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.PersonContext.Referee;
    using FootballTournamentSystem.Application.Features.PersonContext.Referee;

    internal class RefereeRepository : DataRepository<FootballTournamentDbContext, Referee>, IRefereeRepository
    {
        public RefereeRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
