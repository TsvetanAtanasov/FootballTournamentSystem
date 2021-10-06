namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.PlayerStatistics
{
    using Domain.Models.Statistics.PlayerStatistics;
    using FootballTournamentSystem.Application.Features.Statistics.PlayerStatistics;

    internal class PlayerStatisticsRepository : FootballTournamentDataRepository<PlayerStatistics>, IPlayerStatisticsRepository
    {
        public PlayerStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
