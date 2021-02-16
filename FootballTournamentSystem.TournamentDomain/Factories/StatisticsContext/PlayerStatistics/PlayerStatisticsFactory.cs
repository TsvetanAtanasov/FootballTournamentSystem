namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.PlayerStatistics
{
    using Models.StatisticsContext.PlayerStatistics;

    internal class PlayerStatisticsFactory : IPlayerStatisticsFactory
    {
        private int goalsScored = default!;
        private int minutesPlayed = default!;
        private int assists = default!;

        public IPlayerStatisticsFactory WithGoalsScored(int goalsScored)
        {
            this.goalsScored = goalsScored;
            return this;
        }

        public IPlayerStatisticsFactory WithMinutesPlayed(int minutesPlayed)
        {
            this.minutesPlayed = minutesPlayed;
            return this;
        }

        public IPlayerStatisticsFactory WithAssists(int assists)
        {
            this.assists = assists;
            return this;
        }

        public PlayerStatistics Build() => new PlayerStatistics(this.goalsScored, this.minutesPlayed, this.assists);
    }
}
