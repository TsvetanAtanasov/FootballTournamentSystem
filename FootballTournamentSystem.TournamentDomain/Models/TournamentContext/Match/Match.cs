namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;

    public class Match : Entity<int>, IAggregateRoot
    {
        public Match(Team homeTeam, Team awayTeam, MatchDetails matchDetails)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.MatchDetails = matchDetails;
        }

        public Team HomeTeam { get; }

        public Team AwayTeam { get; }

        public MatchDetails MatchDetails { get; }
    }
}
