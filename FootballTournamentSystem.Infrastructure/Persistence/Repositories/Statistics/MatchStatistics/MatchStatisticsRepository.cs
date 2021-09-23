namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.MatchStatistics
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.StatisticsContext.MatchStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.MatchStatistics;

    internal class MatchStatisticsRepository : FootballTournamentDataRepository<MatchStatistics>, IMatchStatisticsRepository
    {
        public MatchStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
