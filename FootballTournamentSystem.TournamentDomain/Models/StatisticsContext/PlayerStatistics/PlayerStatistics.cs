namespace FootballTournamentSystem.Domain.Models.StatisticsContext.PlayerStatistics
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;

    public class PlayerStatistics : Entity<int>
    {
        internal PlayerStatistics(int goalsScored, int minutesPlayed, int assists)
        {
            this.Validate(goalsScored, minutesPlayed, assists);

            this.GoalsScored = goalsScored;
            this.MinutesPlayed = minutesPlayed;
            this.Assists = assists;
        }

        public int GoalsScored { get; }

        public int MinutesPlayed { get; }

        public int Assists { get; }

        private void Validate(int goalsScored, int minutesPlayed, int assists)
        {
            Guard.ForPositiveNumber<InvalidPlayerStatisticsException>(
            goalsScored,
            nameof(this.GoalsScored));

            Guard.ForPositiveNumber<InvalidPlayerStatisticsException>(
            minutesPlayed,
            nameof(this.MinutesPlayed));

            Guard.ForPositiveNumber<InvalidPlayerStatisticsException>(
            assists,
            nameof(this.Assists));
        }
    }
}
