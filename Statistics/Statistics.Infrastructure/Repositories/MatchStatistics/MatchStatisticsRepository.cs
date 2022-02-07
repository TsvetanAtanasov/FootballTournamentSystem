namespace FootballTournamentSystem.Statistics.Infrastructure.Repositories.MatchStatistics
{
    using FootballTournamentSystem.Statistics.Domain.Models.MatchStatistics;
    using FootballTournamentSystem.Statistics.Application.Features.MatchStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;

    internal class MatchStatisticsRepository : FootballTournamentDataRepository<MatchStatistics>, IMatchStatisticsRepository
    {
        public MatchStatisticsRepository(StatisticsDbContext db)
            : base(db)
        {

        }
    }
}
