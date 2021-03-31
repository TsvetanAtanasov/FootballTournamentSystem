namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Domain.Models.PersonContext.Referee;

    public class Match : Entity<int>, IAggregateRoot
    {
        internal Match(Team homeTeam, Team awayTeam)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }

        public Team HomeTeam { get; }

        public Team AwayTeam { get; }

        public int PlayerStatisticsId { get; private set; }

        public int MatchStatisticsId { get; private set; }

        public int RefereeId { get; private set; }

        public void AddReferee(int refereeId) => this.RefereeId = refereeId;

        public void AddMatchStatistics(int statisticsId) => this.MatchStatisticsId = statisticsId;

        public void AddPlayerStatistics(int statisticsId) => this.PlayerStatisticsId = statisticsId;
    }
}
