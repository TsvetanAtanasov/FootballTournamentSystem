namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.Referee
{
    using Domain.Models.PersonContext.Referee;
    using FootballTournamentSystem.Application.Features.PersonContext.Referee;

    internal class RefereeRepository : DataRepository<Referee>, IRefereeRepository
    {
        public RefereeRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
