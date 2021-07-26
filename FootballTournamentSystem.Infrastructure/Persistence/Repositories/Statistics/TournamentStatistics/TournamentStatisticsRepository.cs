namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.TournamentStatistics
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.StatisticsContext.TournamentStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.TournamentStatistics;

    internal class TournamentStatisticsRepository : DataRepository<FootballTournamentDbContext, TournamentStatistics>, ITournamentStatisticsRepository
    {
        public TournamentStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
