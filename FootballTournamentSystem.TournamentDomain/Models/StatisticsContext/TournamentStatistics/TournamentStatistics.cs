namespace FootballTournamentSystem.Domain.Models.StatisticsContext.TournamentStatistics
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using FootballTournamentSystem.Domain.Models.PersonContext.Player;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;

    public class TournamentStatistics : Entity<int>, IAggregateRoot
    {
        internal TournamentStatistics(int goalsScored, Player goalScorer, Team winner)
        {
            this.Validate(goalsScored);

            this.GoalsScored = goalsScored;
            this.GoalScorer = goalScorer;
            this.Winner = winner;
        }

        public int GoalsScored { get; }

        public Player GoalScorer { get; }

        public Team Winner { get; }

        private void Validate(int goalsScored)
        {
            Guard.ForPositiveNumber<InvalidTournamentStatisticsException>(
            goalsScored,
            nameof(this.GoalsScored));
        }
    }
}
