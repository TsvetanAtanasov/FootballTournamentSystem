namespace FootballTournamentSystem.Person.Domain.Models.President
{
    using Core.Domain.Events;

    public class President : Person
    {
        internal President(string firstName, string lastName, string imageUrl, int teamId)
            : base(firstName, lastName, imageUrl)
        {
            this.TeamId = teamId;

            this.RaiseEvent(new PresidentCreatedEvent(this.Id, this.TeamId));
        }

        private President()
            : base()
        {
        }

        public int TeamId { get; }
    }
}
