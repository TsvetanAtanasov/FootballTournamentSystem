namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.PlayerStatistics
{
    using Models.StatisticsContext.PlayerStatistics;

    public interface IPlayerStatisticsFactory : IFactory<PlayerStatistics>
    {
        IPlayerStatisticsFactory WithGoalsScored(int goalsScored);

        IPlayerStatisticsFactory WithMinutesPlayed(int minutesPlayed);

        IPlayerStatisticsFactory WithAssists(int assists);
    }
}
