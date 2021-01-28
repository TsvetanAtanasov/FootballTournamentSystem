namespace FootballTournamentSystem.Domain.Models.PlayerContext.Player
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Models.StatisticsContext.PlayerStatistics;
    using System.Collections.Generic;
    using System.Linq;

    public class Player : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<PlayerStatistics> playerStatistics;

        public Player(PlayerDetails playerDetails)
        {
            this.PlayerDetails = playerDetails;

            this.playerStatistics = new HashSet<PlayerStatistics>();
        }

        public PlayerDetails PlayerDetails { get; }


        public IReadOnlyCollection<PlayerStatistics> PlayerStatistics => this.playerStatistics.ToList().AsReadOnly();
    }
}
