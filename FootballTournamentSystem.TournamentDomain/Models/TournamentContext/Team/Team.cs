namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.PlayerContext.Player;
    using FootballTournamentSystem.Domain.Models.StatisticsContext.TeamStatistics;
    using System.Collections.Generic;
    using System.Linq;

    public class Team : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<TeamStatistics> teamStatistics;
        private readonly HashSet<Player> players;

        public Team(TeamDetails teamDetails)
        {
            this.TeamDetails = teamDetails;

            this.teamStatistics = new HashSet<TeamStatistics>();
            this.players = new HashSet<Player>();
        }
        public IReadOnlyCollection<TeamStatistics> TeamStatistics => this.teamStatistics.ToList().AsReadOnly();

        public IReadOnlyCollection<Player> Players => this.players.ToList().AsReadOnly();

        public void AddPlayer(Player player) => this.players.Add(player);

        public TeamDetails TeamDetails { get; }
    }
}
