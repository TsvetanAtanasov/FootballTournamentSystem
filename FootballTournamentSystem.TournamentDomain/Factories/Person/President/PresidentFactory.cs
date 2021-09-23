namespace FootballTournamentSystem.Domain.Factories.Person.President
{
    using Models.Person.President;

    internal class PresidentFactory : IPresidentFactory
    {
        private string firstName = default!;
        private string lastName = default!;
        private string imageUrl = default!;
        private int teamId;

        public IPresidentFactory WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public IPresidentFactory WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public IPresidentFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public IPresidentFactory WithTeamId(int teamId)
        {
            this.teamId = teamId;
            return this;
        }

        public President Build() => new President(this.firstName, this.lastName, this.imageUrl, this.teamId);
    }
}
