namespace FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics
{
    using Core.Application.Contracts;
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;

    public interface ITournamentStatisticsRepository : IRepository<TournamentStatistics>
    {
    }
}
