namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.PlayerStatistics
{
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.PlayerStatistics;

    internal class PlayerStatisticsRepository : DataRepository<PlayerStatistics>, IPlayerStatisticsRepository
    {
        public PlayerStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
