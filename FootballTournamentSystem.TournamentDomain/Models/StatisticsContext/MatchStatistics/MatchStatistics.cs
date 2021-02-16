namespace FootballTournamentSystem.Domain.Models.StatisticsContext.MatchStatistics
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using FootballTournamentSystem.Domain.Models.PlayerContext.Player;
    using System.Collections.Generic;
    using System.Linq;

    public class MatchStatistics : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Player> goalScorers;
        private readonly HashSet<Player> assistMakers;

        internal MatchStatistics(int homeTeamGoals, int awayTeamGoals)
        {
            this.Validate(homeTeamGoals, awayTeamGoals);

            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;

            this.goalScorers = new HashSet<Player>();
            this.assistMakers = new HashSet<Player>();

            // add referee
        }

        public int HomeTeamGoals { get; }

        public int AwayTeamGoals { get; }


        public IReadOnlyCollection<Player> GoalScorers => this.goalScorers.ToList().AsReadOnly();

        public IReadOnlyCollection<Player> AssistMakers => this.assistMakers.ToList().AsReadOnly();

        public void AddGoalScorer(Player goalScorer) => this.goalScorers.Add(goalScorer);

        public void AddAssistMaker(Player assistMaker) => this.assistMakers.Add(assistMaker);

        private void Validate(int homeTeamGoals, int awayTeamGoals)
        {
            Guard.ForPositiveNumber<InvalidMatchStatisticsException>(
            homeTeamGoals,
            nameof(this.HomeTeamGoals));

            Guard.ForPositiveNumber<InvalidMatchStatisticsException>(
            awayTeamGoals,
            nameof(this.AwayTeamGoals));
        }
    }
}
