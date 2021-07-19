namespace FootballTournamentSystem.Domain.Models.TournamentContext.Match
{
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;
    using global::Common.Domain;
    using global::Common.Domain.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class Match : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Team> teams;

        internal Match(Team homeTeam, Team awayTeam)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;

            this.teams = new HashSet<Team>() { homeTeam, awayTeam };
        }

        private Match()
        {
            this.HomeTeam = default!;
            this.AwayTeam = default!;
            this.teams = default!;
        }

        public Team HomeTeam { get; }

        public Team AwayTeam { get; }

        // for database connection
        public IReadOnlyCollection<Team> Teams => this.teams.ToList().AsReadOnly();

        public int PlayerStatisticsId { get; private set; }

        public int MatchStatisticsId { get; private set; }

        public int RefereeId { get; private set; }

        public void AddReferee(int refereeId) => this.RefereeId = refereeId;

        public void AddMatchStatistics(int statisticsId) => this.MatchStatisticsId = statisticsId;

        public void AddPlayerStatistics(int statisticsId) => this.PlayerStatisticsId = statisticsId;
    }
}
