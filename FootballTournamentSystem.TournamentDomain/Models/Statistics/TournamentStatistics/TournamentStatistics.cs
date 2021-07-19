namespace FootballTournamentSystem.Domain.Models.StatisticsContext.TournamentStatistics
{
    using FootballTournamentSystem.Domain.Exceptions;
    using global::Common.Domain;
    using global::Common.Domain.Models;

    public class TournamentStatistics : Entity<int>, IAggregateRoot
    {
        internal TournamentStatistics(int goalsScored)
        {
            this.Validate(goalsScored);

            this.GoalsScored = goalsScored;
        }

        public int GoalsScored { get; }

        public int GoalScorerId { get; private set; }

        public int WinnerTeamId { get; private set; }

        public void AddGoalScorer(int goalScorerId) => this.GoalScorerId = goalScorerId;

        public void AddWinnerTeam(int winnerTeamId) => this.WinnerTeamId = winnerTeamId;

        private void Validate(int goalsScored)
        {
            Guard.ForPositiveNumber<InvalidTournamentStatisticsException>(
            goalsScored,
            nameof(this.GoalsScored));
        }
    }
}
