namespace FootballTournamentSystem.Domain.Factories.PersonContext.Player
{
    using Models.PersonContext.Player;

    internal class PlayerFactory : IPlayerFactory
    {
        private string firstName = default!;
        private string lastName = default!;
        private double height = default!;
        private double weight = default!;
        private string imageUrl = default!;

        public IPlayerFactory WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public IPlayerFactory WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public IPlayerFactory WithHeight(double height)
        {
            this.height = height;
            return this;
        }

        public IPlayerFactory WithWeight(double weight)
        {
            this.weight = weight;
            return this;
        }

        public IPlayerFactory WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }

        public Player Build() => new Player(this.firstName, this.lastName, this.height, this.weight, this.imageUrl);
    }
}
