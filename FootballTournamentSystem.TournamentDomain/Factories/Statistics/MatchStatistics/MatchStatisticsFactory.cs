namespace FootballTournamentSystem.Domain.Factories.Statistics.MatchStatistics
{
    using Models.Statistics.MatchStatistics;

    internal class MatchStatisticsFactory : IMatchStatisticsFactory
    {
        private int homeGoals = default!;
        private int awayGoals = default!;

        public IMatchStatisticsFactory WithHomeTeamGoals(int homeGoals)
        {
            this.homeGoals = homeGoals;
            return this;
        }

        public IMatchStatisticsFactory WithAwayTeamGoals(int awayGoals)
        {
            this.awayGoals = awayGoals;
            return this;
        }

        public MatchStatistics Build() => new MatchStatistics(this.homeGoals, this.awayGoals);
    }
}
