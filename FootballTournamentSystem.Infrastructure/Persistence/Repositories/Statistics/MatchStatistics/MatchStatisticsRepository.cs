namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.MatchStatistics
{
    using Domain.Models.Statistics.MatchStatistics;
    using FootballTournamentSystem.Application.Features.Statistics.MatchStatistics;

    internal class MatchStatisticsRepository : FootballTournamentDataRepository<MatchStatistics>, IMatchStatisticsRepository
    {
        public MatchStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
