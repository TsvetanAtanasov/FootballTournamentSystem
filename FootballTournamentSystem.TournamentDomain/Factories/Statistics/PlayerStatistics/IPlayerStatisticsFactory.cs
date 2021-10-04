﻿namespace FootballTournamentSystem.Domain.Factories.Statistics.PlayerStatistics
{
    using global::Common.Domain;
    using Models.Statistics.PlayerStatistics;

    public interface IPlayerStatisticsFactory : IFactory<PlayerStatistics>
    {
        IPlayerStatisticsFactory WithGoalsScored(int goalsScored);

        IPlayerStatisticsFactory WithMinutesPlayed(int minutesPlayed);

        IPlayerStatisticsFactory WithAssists(int assists);
    }
}
