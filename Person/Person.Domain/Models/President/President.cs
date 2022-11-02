namespace FootballTournamentSystem.Person.Domain.Models.President
{
    public class President : Person
    {
        internal President(string firstName, string lastName, string imageUrl, int teamId)
            : base(firstName, lastName, imageUrl)
        {
            this.TeamId = teamId;
        }

        private President()
            : base()
        {
        }

        public int TeamId { get; }
    }
}
