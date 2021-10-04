namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Statistics.TournamentStatistics
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.Statistics.TournamentStatistics;
    using FootballTournamentSystem.Application.Features.Statistics.TournamentStatistics;

    internal class TournamentStatisticsRepository : FootballTournamentDataRepository<TournamentStatistics>, ITournamentStatisticsRepository
    {
        public TournamentStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
