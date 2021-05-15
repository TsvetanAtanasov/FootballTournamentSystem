namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.President
{
    using Domain.Models.PersonContext.President;
    using FootballTournamentSystem.Application.Features.PersonContext.President;

    internal class PresidentRepository : DataRepository<President>, IPresidentRepository
    {
        public PresidentRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
