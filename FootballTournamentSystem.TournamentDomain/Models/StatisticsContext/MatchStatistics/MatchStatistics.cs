namespace FootballTournamentSystem.Domain.Models.StatisticsContext.MatchStatistics
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;
    using FootballTournamentSystem.Domain.Models.PersonContext.Player;
    using System.Collections.Generic;
    using System.Linq;

    public class MatchStatistics : Entity<int>, IAggregateRoot
    {
        private readonly List<int> goalScorerIds;
        private readonly List<int> assistMakerIds;

        internal MatchStatistics(int homeTeamGoals, int awayTeamGoals)
        {
            this.Validate(homeTeamGoals, awayTeamGoals);

            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;

            this.goalScorerIds = new List<int>();
            this.assistMakerIds = new List<int>();
        }

        public int HomeTeamGoals { get; }

        public int AwayTeamGoals { get; }


        public IReadOnlyCollection<int> GoalScorerIds => this.goalScorerIds.ToList().AsReadOnly();

        public IReadOnlyCollection<int> AssistMakerIds => this.assistMakerIds.ToList().AsReadOnly();

        public void AddGoalScorers(List<int> goalScorerIds) => this.goalScorerIds.AddRange(goalScorerIds);

        public void AddAssistMakers(List<int> assistMakerIds) => this.assistMakerIds.AddRange(assistMakerIds);

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
