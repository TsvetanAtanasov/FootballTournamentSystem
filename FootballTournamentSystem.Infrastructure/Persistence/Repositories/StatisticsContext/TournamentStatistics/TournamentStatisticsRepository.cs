namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.StatisticsContext.TournamentStatistics
{
    using Domain.Models.StatisticsContext.TournamentStatistics;
    using FootballTournamentSystem.Application.Features.StatisticsContext.TournamentStatistics;

    internal class TournamentStatisticsRepository : DataRepository<TournamentStatistics>, ITournamentStatisticsRepository
    {
        public TournamentStatisticsRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
