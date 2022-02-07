namespace FootballTournamentSystem.Statistics.Infrastructure.Repositories.PlayerStatistics
{
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Domain.Models.PlayerStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;

    internal class PlayerStatisticsRepository : FootballTournamentDataRepository<PlayerStatistics>, IPlayerStatisticsRepository
    {
        public PlayerStatisticsRepository(StatisticsDbContext db)
            : base(db)
        {

        }
    }
}
