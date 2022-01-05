namespace FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics
{
    using Core.Application.Contracts;
    using FootballTournamentSystem.Statistics.Domain.Models.PlayerStatistics;

    public interface IPlayerStatisticsRepository : IRepository<PlayerStatistics>
    {
    }
}
