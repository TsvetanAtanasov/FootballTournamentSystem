namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;

    public class MatchDetails : ValueObject
    {
        internal MatchDetails(int homeTeamGoals, int awayTeamGoals)
        {
            this.Validate(homeTeamGoals, awayTeamGoals);
            // todo add more properties
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals { get; }

        public int AwayTeamGoals { get; }

        private void Validate(int homeTeamGoals, int awayTeamGoals)
        {
            Guard.ForPositiveNumber<InvalidMatchDetailsException>(
            homeTeamGoals,
            nameof(this.HomeTeamGoals));

            Guard.ForPositiveNumber<InvalidMatchDetailsException>(
            awayTeamGoals,
            nameof(this.AwayTeamGoals));
        }
    }
}
