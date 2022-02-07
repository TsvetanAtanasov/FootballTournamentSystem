namespace FootballTournamentSystem.Statistics.Domain.Factories.PlayerStatistics
{
    using Core.Domain;
    using FootballTournamentSystem.Statistics.Domain.Models.PlayerStatistics;

    public interface IPlayerStatisticsFactory : IFactory<PlayerStatistics>
    {
        IPlayerStatisticsFactory WithGoalsScored(int goalsScored);

        IPlayerStatisticsFactory WithMinutesPlayed(int minutesPlayed);

        IPlayerStatisticsFactory WithAssists(int assists);
    }
}
