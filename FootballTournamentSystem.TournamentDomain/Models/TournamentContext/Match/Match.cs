namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Domain.Exceptions;

    public class Match : Entity<int>, IAggregateRoot
    {
        public Match(Team homeTeam, Team awayTeam)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }

        public Team HomeTeam { get; }

        public Team AwayTeam { get; }

        public int PlayerStatisticsId { get; }

        public int MatchStatisticsId { get; }
    }
}
