namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.TournamentStatistics
{
    using Models.Person.Player;
    using Models.TournamentContext.Team;
    using Models.StatisticsContext.TournamentStatistics;

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
