namespace FootballTournamentSystem.Person.Domain.Factories.Referee
{
    using FootballTournamentSystem.Person.Domain.Models.Referee;

    internal class RefereeFactory : IRefereeFactory
    {
        private string firstName = default!;
        private string lastName = default!;
        private string imageUrl = default!;

        public IRefereeFactory WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public IRefereeFactory WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public IRefereeFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public Referee Build() => new Referee(this.firstName, this.lastName, this.imageUrl);
    }
}
