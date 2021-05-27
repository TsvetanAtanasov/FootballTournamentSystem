namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.MatchStatistics
{
    using Domain.Models.StatisticsContext.MatchStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.MatchStatistics;

    internal class MatchStatisticsRepository : DataRepository<MatchStatistics>, IMatchStatisticsRepository
    {
        public MatchStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
