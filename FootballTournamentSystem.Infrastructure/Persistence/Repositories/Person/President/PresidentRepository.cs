namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.President
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.Person.President;
    using FootballTournamentSystem.Application.Features.Person.President;

    internal class PresidentRepository : FootballTournamentDataRepository<President>, IPresidentRepository
    {
        public PresidentRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
