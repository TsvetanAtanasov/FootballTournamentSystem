namespace FootballTournamentSystem.Domain.Models.PersonContext.Coach
{
    public class Coach : Person
    {
        internal Coach(string firstName, string lastName, string imageUrl)
            : base(firstName, lastName, imageUrl)
        {
        }

        public int TeamId { get; private set; }

        public void AssignTeam(int teamId) => this.TeamId = teamId;
    }
}
