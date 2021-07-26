namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.President
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.PersonContext.President;
    using FootballTournamentSystem.Application.Features.PersonContext.President;

    internal class PresidentRepository : DataRepository<FootballTournamentDbContext, President>, IPresidentRepository
    {
        public PresidentRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
