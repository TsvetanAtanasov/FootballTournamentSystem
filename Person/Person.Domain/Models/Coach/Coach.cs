namespace FootballTournamentSystem.Person.Domain.Models.Coach
{
    public class Coach : Person
    {
        internal Coach(string firstName, string lastName, string imageUrl, int teamId)
            : base(firstName, lastName, imageUrl)
        {
            this.TeamId = teamId;
        }

        private Coach() 
            : base()
        {

        }

        public int TeamId { get; }
    }
}
