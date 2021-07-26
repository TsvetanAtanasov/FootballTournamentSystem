namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.PlayerStatistics
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.StatisticsContext.PlayerStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.PlayerStatistics;

    internal class PlayerStatisticsRepository : DataRepository<FootballTournamentDbContext, PlayerStatistics>, IPlayerStatisticsRepository
    {
        public PlayerStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
