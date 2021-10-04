namespace FootballTournamentSystem.Domain.Factories.Statistics.TournamentStatistics
{
    using Models.Person.Player;
    using Models.Tournament.Team;
    using Models.Statistics.TournamentStatistics;

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
