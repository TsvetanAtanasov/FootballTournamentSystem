namespace FootballTournamentSystem.Domain.Factories.StatisticsContext.TournamentStatistics
{
    using Models.PersonContext.Player;
    using Models.TournamentContext.Team;
    using Models.StatisticsContext.TournamentStatistics;

    internal class TournamentStatisticsFactory : ITournamentStatisticsFactory
    {
        private int goalsScored = default!;
        private Player goalScorer = default!;
        private Team winner = default!;

        public ITournamentStatisticsFactory WithGoalsScored(int goalsScored)
        {
            this.goalsScored = goalsScored;
            return this;
        }

        public ITournamentStatisticsFactory WithGoalScorer(Player goalScorer)
        {
            this.goalScorer = goalScorer;
            return this;
        }

        public ITournamentStatisticsFactory WithWinner(Team winner)
        {
            this.winner = winner;
            return this;
        }

        public TournamentStatistics Build() => new TournamentStatistics(this.goalsScored, this.goalScorer, this.winner);
    }
}
