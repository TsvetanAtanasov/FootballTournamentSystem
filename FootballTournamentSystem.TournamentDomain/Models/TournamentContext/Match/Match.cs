namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Domain.Models.PersonContext.Referee;

    public class Match : Entity<int>, IAggregateRoot
    {
        internal Match(Team homeTeam, Team awayTeam, Referee referee)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Referee = referee;
        }

        public Team HomeTeam { get; }

        public Team AwayTeam { get; }

        public Referee Referee { get; }

        public int PlayerStatisticsId { get; }

        public int MatchStatisticsId { get; }
    }
}
