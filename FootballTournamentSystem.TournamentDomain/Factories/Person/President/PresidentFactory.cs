namespace FootballTournamentSystem.Domain.Factories.PersonContext.President
{
    using Models.PersonContext.President;

    internal class PresidentFactory : IPresidentFactory
    {
        private string firstName = default!;
        private string lastName = default!;
        private string imageUrl = default!;

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

        public President Build() => new President(this.firstName, this.lastName, this.imageUrl);
    }
}
