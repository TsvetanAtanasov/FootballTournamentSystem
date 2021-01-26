namespace FootballTournamentSystem.Domain.Models.TournamentContext.Team
{
    using FootballTournamentSystem.Domain.Common;

    public class Team : Entity<int>, IAggregateRoot
    {
        public Team(TeamDetails teamDetails)
        {
            this.TeamDetails = teamDetails;
        }

        public TeamDetails TeamDetails { get; }
    }
}
