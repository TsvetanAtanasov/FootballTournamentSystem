namespace FootballTournamentSystem.Statistics.Infrastructure.Repositories.TournamentStatistics
{
    using FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics;
    using Statistics.Infrastructure.Repositories;
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;
    using FootballTournamentSystem.Statistics.Infrastructure.Persistance;

    internal class TournamentStatisticsRepository : FootballTournamentDataRepository<TournamentStatistics>, ITournamentStatisticsRepository
    {
        public TournamentStatisticsRepository(StatisticsDbContext db)
            : base(db)
        {

        }
    }
}
