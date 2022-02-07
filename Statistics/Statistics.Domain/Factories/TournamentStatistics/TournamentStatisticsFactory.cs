namespace FootballTournamentSystem.Statistics.Domain.Factories.TournamentStatistics
{
    using FootballTournamentSystem.Statistics.Domain.Models.TournamentStatistics;

    internal class TournamentStatisticsFactory : ITournamentStatisticsFactory
    {
        private int goalsScored = default!;

        public ITournamentStatisticsFactory WithGoalsScored(int goalsScored)
        {
            this.goalsScored = goalsScored;
            return this;
        }

        public TournamentStatistics Build() => new TournamentStatistics(this.goalsScored);
    }
}
