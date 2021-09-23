namespace FootballTournamentSystem.Domain.Factories.Person.Coach
{
    using Models.Person.Coach;

    internal class CoachFactory : ICoachFactory
    {
        private string firstName = default!;
        private string lastName = default!;
        private string imageUrl = default!;

        public ICoachFactory WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public ICoachFactory WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public ICoachFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public Coach Build() => new Coach(this.firstName, this.lastName, this.imageUrl);
    }
}
